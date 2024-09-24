USE NinjaManager;
GO

INSERT INTO Ninja (id, name, currency) VALUES 
(1, 'Shadow', 500),
(2, 'Blaze', 1000),
(3, 'Thunder', 750);

INSERT INTO Category (id, name) VALUES
(1, 'Head'),
(2, 'Chest'),
(3, 'Hand'),
(4, 'Feet'),
(5, 'Ring'),
(6, 'Necklace');

-- Insert 3 equipment items for each category with name property
INSERT INTO Equipment (id, name, price, strength, intelligence, agility, category_id) VALUES
-- Head category (id = 1)
(1, 'Iron Helmet', 100, 10, 0, 5, 1),  -- Head equipment 1
(2, 'Steel Helmet', 150, 12, 2, 6, 1), -- Head equipment 2
(3, 'Golden Helmet', 200, 15, 3, 8, 1),-- Head equipment 3

-- Chest category (id = 2)
(4, 'Leather Armor', 200, 15, 5, 5, 2), -- Chest equipment 1
(5, 'Chainmail Armor', 250, 18, 7, 4, 2), -- Chest equipment 2
(6, 'Dragon Scale Armor', 300, 20, 8, 6, 2), -- Chest equipment 3

-- Hand category (id = 3)
(7, 'Leather Gloves', 50, 5, 0, 10, 3), -- Hand equipment 1
(8, 'Iron Gauntlets', 80, 7, 1, 12, 3), -- Hand equipment 2
(9, 'Golden Gauntlets', 100, 10, 2, 15, 3), -- Hand equipment 3

-- Feet category (id = 4)
(10, 'Leather Boots', 80, 8, 0, 8, 4),  -- Feet equipment 1
(11, 'Iron Boots', 120, 10, 0, 10, 4),  -- Feet equipment 2
(12, 'Golden Boots', 150, 12, 0, 12, 4),-- Feet equipment 3

-- Ring category (id = 5)
(13, 'Silver Ring', 150, 0, 20, 5, 5),  -- Ring equipment 1
(14, 'Golden Ring', 180, 0, 25, 7, 5),  -- Ring equipment 2
(15, 'Platinum Ring', 220, 0, 30, 10, 5), -- Ring equipment 3

-- Necklace category (id = 6)
(16, 'Silver Necklace', 120, 0, 15, 10, 6),  -- Necklace equipment 1
(17, 'Golden Necklace', 150, 0, 18, 12, 6),  -- Necklace equipment 2
(18, 'Platinum Necklace', 180, 0, 20, 15, 6); -- Necklace equipment 3



INSERT INTO NinjaEquipment (ninja_id, equipment_id) VALUES
(1, 1),  -- Shadow has a Head equipment
(1, 2);  -- Shadow has a Chest equipment

INSERT INTO NinjaEquipment (ninja_id, equipment_id) VALUES
(2, 3),  -- Blaze has a Hand equipment
(2, 4);  -- Blaze has a Feet equipment

INSERT INTO NinjaEquipment (ninja_id, equipment_id) VALUES
(3, 5),  -- Thunder has a Ring equipment
(3, 6);  -- Thunder has a Necklace equipment


USE master;