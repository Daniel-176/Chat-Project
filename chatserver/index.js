const WSSS = require('ws');
const wss = new WSSS.WebSocketServer({
  port: 8080
});

wss.on('connection', function connection(ws) {
  // Event triggered when a new client connects

  // Event triggered when a client sends a message
  console.log('Client connected');
  ws.on('message', function incoming(message) {
    const messageBuffer = Buffer.from(message);
    const messageString = messageBuffer.toString('utf8');

    var msg = JSON.parse(messageString)
    console.log(msg)
    if(msg.type == "sendmsg") {
      if(msg.UserName == "" || msg.UserName == undefined || !msg.UserName) return;
      if(msg.txt == "" || msg.txt == undefined || !msg.txt) return;
      wss.clients.forEach(c => {
          c.send(msg)
      })
    }
  });

  // Event triggered when a client disconnects
  ws.on('close', function close() {
    console.log('Client disconnected');
    
    // Perform any cleanup or additional actions on client disconnection
    // ...
  });
});

// Event triggered when the WebSocket server starts listening
wss.on('listening', function () {
  console.log('WebSocket server is listening on port 8080');
});

// Event triggered when an error occurs in the WebSocket server
wss.on('error', function (error) {
  console.error('WebSocket server error:', error);
});
