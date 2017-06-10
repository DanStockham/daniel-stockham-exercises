-- Write queries to return the following:
-- The following changes are applied to the "pagila" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
VALUES ('HAMPTON', 'AVENUE');
INSERT INTO actor (first_name, last_name)
VALUES ('LISA', 'BYWAY');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	
INSERT INTO film (title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 198);
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (film_id, actor_id)
VALUES (1001, 201);
INSERT INTO film_actor (film_id, actor_id)
VALUES (1001, 202);
-- 4. Add Mathmagical to the category table.
INSERT INTO category (name)
VALUES ('Mathmagical');

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

INSERT INTO film_category(category_id, film_id)
VALUES (1, 1001)

UPDATE film_category
SET category_id = 17
FROM film_category fc
JOIN film f ON f.film_id = fc.film_id
WHERE f.title IN('Euclidean PI', 'EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE');


-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
FROM film f
JOIN film_category fc ON fc.film_id = f.film_id
WHERE category_id = 17;
-- 7. Add a copy of "Euclidean PI" to all the stores.


INSERT INTO inventory(film_id, store_id)
VALUES (1001, 1)
INSERT INTO inventory(film_id, store_id)
VALUES (1001, 2)


-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)
DELETE FROM film
WHERE film_id = 1001;
--film_actor still has a foreign key for this movie

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)
DELETE FROM category
WHERE name = 'Mathmagical';
--There is still a foreign key in film_category

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)
DELETE FROM film_category
WHERE category_id = 17;
--category_id is a foreign key, thus can be deleted

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)
DELETE FROM category
WHERE name = 'Mathmagical';
DELETE FROM film_actor
WHERE film_id = 1001;
DELETE FROM film
WHERE film_id = 1001;
DELETE FROM inventory
WHERE film_id = 1001;
--They were not successfully with the film since there was still foreign key in inventory.

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.
SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS