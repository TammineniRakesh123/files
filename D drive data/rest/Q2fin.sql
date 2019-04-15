
declare @x int
set @x =33511
--SELECT  [1] as FIRST_NAme,[2] as Last_NAme
 
--FROM (
select x.journey_id1,first_stop,last_stop from(
(

select journey_id1 ,point_name as first_stop from vehiclejourney inner join vehiclejourney_points1 on journey_id1=journey_id
inner join Points on point_id=pointId  where( point_name in(

select point_name from Points where point_id in
(select pointId from vehiclejourney_points1 where
(orderNumber=1 and journey_id1 in
(select journey_id from vehiclejourney where journeyPatternId=@x))) and journeyPatternId=@x  )))x
inner join
(
select journey_id1 ,point_name as last_stop from vehiclejourney inner join vehiclejourney_points1 on journey_id1=journey_id
inner join Points on point_id=pointId  where( point_name in(

select point_name from Points where point_id in
(select pointId from vehiclejourney_points1 where
(orderNumber in (select max(orderNumber) from vehiclejourney_points1 where journey_id1 in
(select journey_id from vehiclejourney where journeyPatternId=@x) and journey_id1 in
(select journey_id from vehiclejourney where journeyPatternId=@x))) and journeyPatternId=@x  ))))y on x.journey_id1=y.journey_id1)
