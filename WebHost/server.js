var express    = require('express')
var logger     = require('morgan')
var bodyParser = require('body-parser')

var app = express();
var server = require('http').createServer(app);
var port = process.env.PORT || 8000;

// Kickoff the app and start listening 
server.listen(port, function(){
    console.log('Application listening on port %d', port);
});

// Define express features
app.use(bodyParser.json())
app.use(logger('dev'))



// Static route to the view
// TODO Borrowed; consider removing;
app.use(express.static(__dirname + '/public'));

// Connects application to our model
var Post = require('./models/post')

// Process POST
/*
TODO: Work this out later
app.post('/api/posts', function (req, res) {
  Post.findByIdAndUpdate(id_part_name[req.body.part_name], { $set: { part_description: req.body.part_description }}, function (err, post){
    if (err) return handleError(err);
    res.send(post);
  });
});
*/

// Process GET
app.get('/api/posts', function(req, res, next){
  Post.find(function(err, posts) {
    if(err){return next(err)}
    res.json(posts);
  });
});
