const fs = require('fs');
const request = require('request');
/*
try {
  var indexdata = JSON.parse(request.get('https://bsm.hauteclaire.me'));
  console.log(JSON.parse(request.get('https://bsm.hauteclaire.me')))
  latestindex = fs.open('index.json', 'w', (err, fd) => {
    fs.readFile(fd, function (err, data) {
      if(data != indexdata) {
        console.log("Index mismatch. Saving remote copy...");
        fs.write(fd, indexdata, function (err) {
          console.log("Wrote to local copy.")
        });
      } else {
        console.log("Local index matches remote copy. Skipping.");
      }
    })
  })
} catch (err) {
  //var options = {type:"error",title:"Oi! It's fucked.", message:"Couldn't reach the API server to download the latest index. Are you connected to the internet?",detail:err};
  //dialog.showMessageBox([BrowserWindow],options);
  console.log('fuck' + err)
}
*/

var remoteindex;
if(fs.existsSync('index.json')) {
  var localindex = fs.readFileSync('index.json');
} else {
  fs.writeFile('index.json', '', function (err) {
    console.log("Created empty index.json.");
  });
};
try {
  request('https://bsm.hauteclaire.me', function (error, response, body) {
    if (error) {
      console.log("Could not communicate with api.");
    } else if(localindex != body) {
      console.log("Data mismatch. Copying remote index to file...");
      fs.writeFile('index.json', body, function (err) {
        console.log("Done.");
      });
    } else {
      console.log("Local and remote index match. Skipping.");
    }
  });
} catch (err) {
  console.log("ERROR: " + err);
}
