INSERT INTO users VALUES 
    ('e8a32b14-99c5-4e82-a9c1-9c80ed45f234', 'John', 'Doe', 'john.doe@example.com', 'john_doe', 'hashed_password_1', '+1', '1234567890'),
    ('49df529a-9b52-4d0a-b9e2-6e45c09f8765', 'Jane', 'Smith', 'jane.smith@example.com', 'jane_smith', 'hashed_password_2', '+44', '9876543210');

INSERT INTO apps VALUES 
    ('94eabf25-57d0-4c5b-9c21-f7221bdcbb82', 'Instagram', 'instagram_icon_url'),
    ('7d3d82dc-1bc7-4f0d-9a30-2a461ca328f1', 'Twitter', 'twitter_icon_url'),
    ('2a46f3c8-9c8e-4dcb-8b01-87958247d5e1', 'Spotify', 'spotify_icon_url'),
    ('8f94c6b5-38d1-4c20-96af-2351d19eac9a', 'Netflix', 'netflix_icon_url'),
    ('b8ec9067-1f88-4b32-b90a-6a9ec78da23a', 'Uber', 'uber_icon_url'),
    ('1f257fae-3a9e-4ed3-8bfb-58ee0ff4c9e8', 'Snapchat', 'snapchat_icon_url'),
    ('72ac82fb-d2b4-4c72-a141-84bea9f9e3f7', 'Microsoft Teams', 'teams_icon_url'),
    ('ab3c2fd8-0da7-4f2f-bae1-8835ae7d29c1', 'Tinder', 'tinder_icon_url'),
    ('5c8fa61d-7e55-4f53-bc9b-f4b4f8be6469', 'LinkedIn', 'linkedin_icon_url'),
    ('f9a117e5-57b3-48b2-b61c-2c1bf3a86423', 'Candy Crush', 'candycrush_icon_url'),
    ('21f7c9b0-1a87-42df-a66e-8c5e2c92c3c6', 'Reddit', 'reddit_icon_url'),
    ('a125e1f8-59d6-4c3e-8f8f-1ff43a6d1a7c', 'Pinterest', 'pinterest_icon_url'),
    ('f3b0c9a1-cede-409a-83b9-9bf2d1b3dce8', 'YouTube', 'youtube_icon_url'),
    ('c7e8fb65-9b9a-4a92-8e19-56f3be321f22', 'Facebook', 'facebook_icon_url'),
    ('bd5f1a20-6e67-4328-8350-84255c9b33a1', 'Amazon', 'amazon_icon_url'),
    ('7b8a2c1d-4e5f-6d7a-8b9c-1d2e3f4a5b6c', 'Dropbox', 'dropbox_icon_url'),
    ('6f7a8b9c-1d2e-3f4a-5b6c-7d8e9f1a2c3d', 'Trello', 'trello_icon_url'),
    ('8b9c1d2e-3f4a-5b6c-7d8e-9f1a2c3d4b5e', 'TikTok', 'tiktok_icon_url'),
    ('1d2e3f4a-5b6c-7d8e-9f1a-2c3d4b5e6f7a', 'Duolingo', 'duolingo_icon_url');

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
