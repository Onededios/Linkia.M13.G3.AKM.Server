INSERT INTO users VALUES
  ('bda7a2b2-152a-4eb8-af92-54b82e9d8ec3', 'John', 'Doe', 'john.doe@email.com', 'johndoe', 'password123', '+1', '1234567890'),
  ('ac04f417-7b35-4ef9-87fb-33b9e0f3e38f', 'Jane', 'Smith', 'jane.smith@email.com', 'janesmith', 'securepass', '+44', '9876543210');

INSERT INTO history_users VALUES
  ('1e72b729-6201-4ee9-85bf-8ed816019a5a', 'bda7a2b2-152a-4eb8-af92-54b82e9d8ec3', 'John', 'Doe', 'john.doe@email.com', 'johndoe', 'password123', '+1', '1234567890', '2024-03-09 12:30:00', '2023-01-15 08:45:00'),
  ('b1cb848c-2dcb-4ad0-b7a2-afe36a530187', 'ac04f417-7b35-4ef9-87fb-33b9e0f3e38f', 'Jane', 'Smith', 'jane.smith@email.com', 'janesmith', 'securepass', '+44', '9876543210', '2024-03-09 10:15:00', '2023-02-20 14:20:00');

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
  ('3ffed1f5-3e34-41a2-bbd3-617d023ad861', 'Work', 'bda7a2b2-152a-4eb8-af92-54b82e9d8ec3'),
  ('47ef44e9-8280-4b02-a8e1-4ce610557f5d', 'Personal', 'ac04f417-7b35-4ef9-87fb-33b9e0f3e38f');

INSERT INTO passwords VALUES
  ('52e03ea3-d5cc-4592-924f-9a9f843a7528', 'bda7a2b2-152a-4eb8-af92-54b82e9d8ec3', '94eabf25-57d0-4c5b-9c21-f7221bdcbb82', 'wordpass123', 'Office document', '2024-06-30 18:00:00'),
  ('f99526cd-49a9-4d35-93b1-110bf4a2da6d', 'ac04f417-7b35-4ef9-87fb-33b9e0f3e38f', '7d3d82dc-1bc7-4f0d-9a30-2a461ca328f1', 'excel@2023', 'Financial data', '2024-04-15 10:30:00');

INSERT INTO history_passwords VALUES
  ('aa09aaac-1727-4e61-8582-158b5b7d4ac0', '52e03ea3-d5cc-4592-924f-9a9f843a7528', 'wordpass123', 'Updated password strength', '2024-06-30 18:00:00', '2024-03-09 14:45:00', '2024-03-09 14:30:00'),
  ('b9be7a32-1e06-4604-aa92-c4f06674fc76', 'f99526cd-49a9-4d35-93b1-110bf4a2da6d', 'excel@2023', 'Changed for security reasons', '2024-04-15 10:30:00', '2024-03-09 11:20:00', '2024-03-09 11:15:00');

INSERT INTO alerts VALUES
  ('dd1b120a-7fb4-415c-960e-738c52502b0b', 'bda7a2b2-152a-4eb8-af92-54b82e9d8ec3', '52e03ea3-d5cc-4592-924f-9a9f843a7528', 'Password expiring soon', '2024-06-25 15:00:00'),
  ('69a94a79-6c98-43e7-9c8b-27ce5a0eef20', 'ac04f417-7b35-4ef9-87fb-33b9e0f3e38f', 'f99526cd-49a9-4d35-93b1-110bf4a2da6d', 'Security alert: Account access', '2024-04-10 08:30:00');

INSERT INTO passwords_has_tags VALUES
  ('52e03ea3-d5cc-4592-924f-9a9f843a7528', '3ffed1f5-3e34-41a2-bbd3-617d023ad861'),
  ('f99526cd-49a9-4d35-93b1-110bf4a2da6d', '47ef44e9-8280-4b02-a8e1-4ce610557f5d');
  
 
 delete from history_users 
 delete from tags
 delete from passwords_has_tags 
 delete from users
 delete from history_passwords 
 delete from passwords 
 delete from apps
 delete from alerts 