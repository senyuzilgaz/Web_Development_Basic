const yargs = require('yargs')
const axios = require('axios').default;

let argv = yargs.argv
let country = argv.country;

if(country){
    let url = `https://restcountries.eu/rest/v2/name/${country}`
    axios.get(url,{

    })  
    .then((response) => {
        let country = response.data[0];
        console.log(country.population);
    })
    .catch(err => {
        console.log(err);
    })
}










/*
const { spawn } = require('child_process');
username = "ben_ilgaz"
password = "selenimi_cok_seviyorum"

// const childPython = spawn('python', ['selen.py']);
// const childPython = spawn('python', ['selen.py']);
const childPython = spawn('python', ['selen.py', username, password]);


childPython.stdout.on('data',(data) => {
    console.log(`Can't login: ${data}`);
});

childPython.stderr.on('data', (data) => {
    console.error(`stderr: ${data}`);
});

childPython.on('close', (code) => {
    console.log(`child process exited with code ${code}`);
});

*/

