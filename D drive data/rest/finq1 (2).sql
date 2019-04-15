select x.journey_id1, first_stop,Last_Stop from (select point_name as first_stop,journey_id1 ,orderNumber from vehiclejourney inner join vehiclejourney_points1 on journey_id1=journey_id
inner join Points on point_id=pointId where 
orderNumber in (select min(orderNumber) as y from vehiclejourney_points1 group by journey_id1))x

inner join

(select point_name  as Last_Stop,journey_id1 ,orderNumber from vehiclejourney inner join vehiclejourney_points1 on journey_id1=journey_id
inner join Points on point_id=pointId where
 orderNumber in
(select max(orderNumber) as y from vehiclejourney_points1 group by journey_id1))y on x.journey_id1=y.journey_id1
