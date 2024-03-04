INSERT INTO users (id, first_name, last_name, email, username, password, country_code, telephone)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440000', 'John', 'Doe', 'john.doe@example.com', 'johndoe', 'password123', '+1', '1234567890'),
    ('550e8400-e29b-41d4-a716-446655440001', 'Jane', 'Smith', 'jane.smith@example.com', 'janesmith', 'securepass', '+1', '9876543210');

INSERT INTO apps (id, name, icon)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440002', 'App1', 'app1.png'),
    ('550e8400-e29b-41d4-a716-446655440003', 'App2', 'app2.png');

INSERT INTO tags (id, name, id_user)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440004', 'Personal', '550e8400-e29b-41d4-a716-446655440000'),
    ('550e8400-e29b-41d4-a716-446655440005', 'Work', '550e8400-e29b-41d4-a716-446655440000'),
    ('550e8400-e29b-41d4-a716-446655440006', 'Entertainment', '550e8400-e29b-41d4-a716-446655440001');

INSERT INTO apps_has_tags (id_app, id_tag)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440002', '550e8400-e29b-41d4-a716-446655440004'),
    ('550e8400-e29b-41d4-a716-446655440002', '550e8400-e29b-41d4-a716-446655440005'),
    ('550e8400-e29b-41d4-a716-446655440003', '550e8400-e29b-41d4-a716-446655440006');

INSERT INTO passwords (id, id_user, id_app, id_tag, password, date_creation, date_expiration, date_last_update)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440007', '550e8400-e29b-41d4-a716-446655440000', '550e8400-e29b-41d4-a716-446655440002', '550e8400-e29b-41d4-a716-446655440004', 'pass123', '2024-01-01', '2025-01-01', '2024-02-15'),
    ('550e8400-e29b-41d4-a716-446655440008', '550e8400-e29b-41d4-a716-446655440001', '550e8400-e29b-41d4-a716-446655440003', '550e8400-e29b-41d4-a716-446655440006', 'securepass', '2024-02-01', '2025-02-01', '2024-03-01');

INSERT INTO passwords_has_tags (id_password, id_tag)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440007', '550e8400-e29b-41d4-a716-446655440004'),
    ('550e8400-e29b-41d4-a716-446655440008', '550e8400-e29b-41d4-a716-446655440006');

INSERT INTO alerts (id, id_user, id_password, message, date_alert)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440009', '550e8400-e29b-41d4-a716-446655440000', '550e8400-e29b-41d4-a716-446655440007', 'Password about to expire!', '2024-12-01'),
    ('550e8400-e29b-41d4-a716-446655440010', '550e8400-e29b-41d4-a716-446655440001', '550e8400-e29b-41d4-a716-446655440008', 'New login detected.', '2024-03-02');

INSERT INTO history_passwords (id, id_password, update_date, description_modification, old_password)
VALUES 
    ('550e8400-e29b-41d4-a716-446655440011', '550e8400-e29b-41d4-a716-446655440007', '2024-02-15', 'Password changed', 'oldpass123'),
    ('550e8400-e29b-41d4-a716-446655440012', '550e8400-e29b-41d4-a716-446655440008', '2024-03-01', 'Password updated', 'oldsecurepass');
