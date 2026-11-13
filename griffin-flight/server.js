const http = require('node:http');
const fs = require('node:fs');
const path = require('node:path');
const { DatabaseSync } = require('node:sqlite');

const db = new DatabaseSync(path.join(__dirname, 'reviews.sqlite'));
db.exec(`CREATE TABLE IF NOT EXISTS reviews (id INTEGER PRIMARY KEY, nickname TEXT NOT NULL, nickname_key TEXT NOT NULL UNIQUE, functionality INTEGER NOT NULL, usability INTEGER NOT NULL, originality INTEGER NOT NULL, comment TEXT NOT NULL, created_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP)`);
const send = (res, status, data) => { res.writeHead(status, {'Content-Type':'application/json; charset=utf-8','X-Content-Type-Options':'nosniff'}); res.end(JSON.stringify(data)); };
const server = http.createServer((req, res) => {
  const pathname = new URL(req.url, 'http://localhost').pathname;
  if (pathname === '/api/reviews' && req.method === 'GET') {
    const reviews = db.prepare('SELECT nickname, functionality, usability, originality, comment, created_at FROM reviews ORDER BY id DESC').all();
    return send(res, 200, { reviews });
  }
  if (pathname === '/api/reviews' && req.method === 'POST') {
    let body = ''; let tooLarge = false;
    req.on('data', chunk => { body += chunk; if (body.length > 10000) tooLarge = true; });
    req.on('end', () => {
      if (tooLarge) return send(res, 413, {error:'Слишком большой запрос.'});
      try {
        const data = JSON.parse(body);
        if (typeof data.nickname !== 'string' || typeof data.comment !== 'string') return send(res, 400, {error:'Заполните все поля.'});
        const nickname = data.nickname.trim().normalize('NFKC'); const comment = data.comment.trim();
        const scores = [data.functionality, data.usability, data.originality];
        if (nickname.length < 2 || nickname.length > 30 || comment.length < 3 || comment.length > 500 || scores.some(n => !Number.isInteger(n) || n < 1 || n > 5)) return send(res, 400, {error:'Укажите псевдоним (2–30 символов), отзыв (3–500 символов) и оценки от 1 до 5.'});
        try { db.prepare('INSERT INTO reviews (nickname,nickname_key,functionality,usability,originality,comment) VALUES (?,?,?,?,?,?)').run(nickname,nickname.toLocaleLowerCase('ru-RU'),...scores,comment); }
        catch (error) { if (String(error.message).includes('UNIQUE')) return send(res, 409, {error:'Этот псевдоним уже оставил отзыв. Выберите другой.'}); throw error; }
        return send(res, 201, {ok:true});
      } catch { return send(res, 400, {error:'Не удалось обработать запрос.'}); }
    }); return;
  }
  if (req.method !== 'GET') return send(res, 405, {error:'Метод не поддерживается.'});
  const files = {'/':'index.html','/style.css':'style.css','/game.js':'game.js'}; const file = files[pathname];
  if (!file) return send(res, 404, {error:'Страница не найдена.'});
  res.writeHead(200, {'Content-Type': file.endsWith('.html') ? 'text/html; charset=utf-8' : file.endsWith('.css') ? 'text/css; charset=utf-8' : 'text/javascript; charset=utf-8', 'X-Content-Type-Options':'nosniff'});
  fs.createReadStream(path.join(__dirname, 'public', file)).pipe(res);
});
server.listen(5500, '127.0.0.1', () => console.log('Грифон доступен: http://127.0.0.1:5500'));
