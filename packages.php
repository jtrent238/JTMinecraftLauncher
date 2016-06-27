<?php
$keys = isset($_GET['key']) ? array_map('trim', explode(',', strtolower($_GET['key']))) : array();
$packages = array();

$packages[] = array(
    'name' => 'The Lost Adventure',
    'title' => 'The Lost Adventure',
    'version' => '2016-04-09-16-21-55',
    'priority' => 5,
    'location' => 'the-lost-adventure.json',
);

$packages[] = array(
    'name' => 'Camp Pack 1.0',
    'title' => 'Camp Pack 1.0',
    'version' => '2016-06-26-14-35-55',
    'priority' => 1,
    'location' => 'camp-pack-1.0.json',
);

$packages[] = array(
    'name' => 'More Than Just Minecraft',
    'title' => 'More Than Just Minecraft',
    'version' => '2016-06-26-14-38-13',
    'priority' => 1,
    'location' => 'more-than-just-minecraft.json',
);

$packages[] = array(
    'name' => 'CursedCraftMC',
    'title' => 'CursedCraftMC',
    'version' => '2016-06-26-14-44-03',
    'priority' => 1,
    'location' => 'cursedcraftmc.json',
);

$packages[] = array(
    'name' => 'DangerZone',
    'title' => 'DangerZone',
    'version' => '2016-06-26-14-42-34',
    'priority' => 1,
    'location' => 'dangerzone.json',
);

$packages[] = array(
    'name' => 'You Always Win ModPack - YAW',
    'title' => 'You Always Win ModPack - YAW',
    'version' => '2016-06-26-14-40-07',
    'priority' => 1,
    'location' => 'you-always-win-modpack---yaw.json',
);

$packages[] = array(
    'name' => '7 Days To Mine',
    'title' => '7 Days To Mine',
    'version' => '2016-06-26-18-10-12',
    'priority' => 1,
    'location' => '7-days-to-mine.json',
);

if (count(array_intersect(array('gwgtz5qucc5fnlrybkbpakuom'), $keys)) > 0)
$packages[] = array(
    'name' => 'Fire_User',
    'title' => 'Fire_User',
    'version' => '2016-06-26-20-36-20',
    'priority' => 0,
    'location' => 'fire_user.json',
);

$out = array('minimumVersion' => 1, 'packages' => $packages);
header('Content-Type: text/plain; charset=utf-8');
echo json_encode($out);
