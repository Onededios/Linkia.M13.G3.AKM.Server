INSERT INTO users VALUES 
    ('e8a32b14-99c5-4e82-a9c1-9c80ed45f234', 'John', 'Doe', 'john.doe@example.com', 'john_doe', 'hashed_password_1', '+1', '1234567890'),
    ('49df529a-9b52-4d0a-b9e2-6e45c09f8765', 'Jane', 'Smith', 'jane.smith@example.com', 'jane_smith', 'hashed_password_2', '+44', '9876543210');

INSERT INTO apps VALUES 
    ('63a9f66b-8be4-4b15-a5e0-6a71a97ba9d9', 'App1', 'app1_icon_url'),
    ('94eabf25-57d0-4c5b-9c21-f7221bdcbb82', 'App2', 'app2_icon_url');

INSERT INTO tags VALUES 
    ('e00730a4-d9ef-4a48-88d8-21b7f34b3543', 'Tag1', 'e8a32b14-99c5-4e82-a9c1-9c80ed45f234'),
    ('9e74324f-0bc2-45f2-82e4-570aa1d44a2d', 'Tag2', '49df529a-9b52-4d0a-b9e2-6e45c09f8765');

INSERT INTO passwords VALUES 
    ('5d5275b1-6538-4f3a-8cf2-09a0d9c442c5', 'e8a32b14-99c5-4e82-a9c1-9c80ed45f234', '63a9f66b-8be4-4b15-a5e0-6a71a97ba9d9', 'e00730a4-d9ef-4a48-88d8-21b7f34b3543', 'password123', '2024-03-06', '2025-03-06', '2024-03-06'),
    ('947b1a4a-6e3d-4c42-9c94-b73d1c93a3bf', '49df529a-9b52-4d0a-b9e2-6e45c09f8765', '94eabf25-57d0-4c5b-9c21-f7221bdcbb82', '9e74324f-0bc2-45f2-82e4-570aa1d44a2d', 'securepass456', '2024-03-06', '2025-03-06', '2024-03-06');

INSERT INTO apps_has_tags VALUES 
    ('63a9f66b-8be4-4b15-a5e0-6a71a97ba9d9', 'e00730a4-d9ef-4a48-88d8-21b7f34b3543'),
    ('94eabf25-57d0-4c5b-9c21-f7221bdcbb82', '9e74324f-0bc2-45f2-82e4-570aa1d44a2d');

INSERT INTO passwords_has_tags VALUES 
    ('5d5275b1-6538-4f3a-8cf2-09a0d9c442c5', 'e00730a4-d9ef-4a48-88d8-21b7f34b3543'),
    ('947b1a4a-6e3d-4c42-9c94-b73d1c93a3bf', '9e74324f-0bc2-45f2-82e4-570aa1d44a2d');

INSERT INTO history_passwords VALUES 
    ('9648c3e0-654f-4a8e-8a4b-27a98a5a4f6c', '5d5275b1-6538-4f3a-8cf2-09a0d9c442c5', '2024-03-06', 'Updated password', 'old_password123'),
    ('6e8b5654-df8d-4b3d-b5c9-94c48a22e136', '947b1a4a-6e3d-4c42-9c94-b73d1c93a3bf', '2024-03-06', 'Password change', 'old_securepass456');

INSERT INTO alerts VALUES 
    ('ed0e8b29-cd61-4d3b-b4b1-9a6b2c9e7ab2', 'e8a32b14-99c5-4e82-a9c1-9c80ed45f234', '5d5275b1-6538-4f3a-8cf2-09a0d9c442c5', 'Password expiring soon!', '2024-03-05'),
    ('ed05a79b-af22-41e2-8e7d-10a70e34514d', '49df529a-9b52-4d0a-b9e2-6e45c09f8765', '947b1a4a-6e3d-4c42-9c94-b73d1c93a3bf', 'Security alert: unusual activity', '2024-03-07');
