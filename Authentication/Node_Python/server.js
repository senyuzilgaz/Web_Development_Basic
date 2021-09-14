var http = require('http');
const { spawn } = require('child_process');
var check = 0;

http.createServer( (req, res) => {

    console.log('Request received');

    res.writeHead(200, { 
        'Content-Type': 'text/plain',
        'Access-Control-Allow-Origin': '*' // implementation of CORS
    });

    req.on('data', function (data) {
        var credentials_json = data.toString('utf8');
        var credentials = JSON.parse(credentials_json);
        console.log(`Sending data to python script...\nUsername: ${credentials.username}, Password: ${credentials.password}`)

        const childPython = spawn('python', ['selen.py', credentials.username, credentials.password]);

        childPython.stdout.on('data',(dat) => {
            console.log(`Can't login: ${dat}`);
            dat.toString('utf8')[0] == "T" ? check=0: check=1;
            res.end(`{"msg": ${check}}`);
        });
        
        childPython.stderr.on('data', (data) => {
            console.error(`stderr: ${data}`);
        });
 
        

    });

}).listen(8080);
console.log("Listening on port: 8080")

