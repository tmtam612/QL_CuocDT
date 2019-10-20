var socket = require('socket.io'),
    express = require('express'),
    https = require('https'),
    http = require('http'),
    logger = require('winston');
// logger.configure({transports: [new logger.transports.Console({ colorize: true, timestamp: true}) ]});
// // logger.remove(logger.transports.Console);
// // logger.add(logger.transports.Console, { colorize: true, timestamp: true});
// logger.info('SocketIO > listening on port');
logger.add(new logger.transports.Console({
    format: logger.format.simple()
}));
logger.info('SocketIO > listening on port');
var app = express();
app.use(express.static(__dirname));
// app.get('/', function(req, res){
//     res.sendFile(__dirname + '/test_php.php');
// });
var http_server = http.createServer(app).listen(3000);
function emitNewOrder(server) {
    var io = socket.listen(server);
    io.sockets.on('connection', function(socket) {
        console.log(1);
        socket.on("send", function(data) {
            console.log(data);
            io.emit("send",data);
        })
    });
}
emitNewOrder(http_server);