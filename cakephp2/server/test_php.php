<?php
include("vendor/autoload.php");
use ElephantIO\Client;
use ElephantIO\Engine\SocketIO\Version1X;
$client = new Client(new Version1X('http://localhost:3000'));

$client->initialize();
$client->emit('send', ['foo' => 'bar']);
$client->close();