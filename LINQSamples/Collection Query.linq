<Query Kind="Expression">
  <Connection>
    <ID>6df88e45-7377-43ff-b2c0-bd1b2fcf218b</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//Simple Group-by with an Anonymous type
from food in Items
//select food with only the description and the current price
select new {food.Description, food.CurrentPrice}