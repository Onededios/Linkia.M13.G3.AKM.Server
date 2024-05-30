-- Crear índices para las tablas
CREATE INDEX idx_users_username ON users (username);
CREATE INDEX idx_users_email ON users (email);
CREATE INDEX idx_history_users_id_user ON history_users (id_user);
CREATE INDEX idx_history_users_date_creation ON history_users (date_creation);
