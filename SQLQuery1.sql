select product.id,product.name, category.name
from product left join category on product.id = category.product_id
