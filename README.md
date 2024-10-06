# Библиотека с тестами находится в OpeningTask.AreaCalculator


# 2 задачка:
 Создание таблиц:
```sql
CREATE TABLE products (
    product_id INT PRIMARY KEY,
    product_name VARCHAR(100)
);

CREATE TABLE categories (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(100)
);

CREATE TABLE product_categories_rel (
    product_id INT,
    category_id INT,
    FOREIGN KEY (product_id) REFERENCES Products(product_id),
    FOREIGN KEY (category_id) REFERENCES Categories(category_id)
);
```

 Запрос по тз:
```sql
SELECT
    p.product_name,
    c.category_name
FROM
    Products p
LEFT JOIN
    product_categories_rel pc ON p.product_id = pc.product_id
LEFT JOIN
    Categories c ON pc.category_id = c.category_id
ORDER BY
    p.product_name, c.category_name;
```
