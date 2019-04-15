select count(*) vehiclejourney where journey_id
(select journy_id from vehiclejourney_points1 where pointId in
(select point_id from Points where point_name=Zandvliet))