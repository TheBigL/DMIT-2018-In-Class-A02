<Query Kind="Expression">
  <Connection>
    <ID>6df88e45-7377-43ff-b2c0-bd1b2fcf218b</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from person in Waiters
where person.ReleaseDate == null
select person