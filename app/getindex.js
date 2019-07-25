const http = require('http');
const fs = require('fs');
function getIndex() {
  try {
    http.get('http://localhost:1338', (resp) => {
      let data = JSON.parse(resp);
      latestindex = fs.open('index.json', 'w', (err, fd) => {
        fs.readFile(fd, function (err, indexdata) {
          if(indexdata != data) {
            console.log("Index mismatch. Saving remote copy...");
            latestindex.write(data);
          } else {
            console.log("Local index matches remote copy. Skipping.");
          }
        })
      })
    })
  } catch (error) {
    var options = {type:"error",title:"Oi! It's fucked.", message:"Couldn't reach the API server to download the latest index. Are you connected to the internet?",detail:error};
    dialog.showMessageBox([BrowserWindow],options);
  };
};
