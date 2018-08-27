// Called by Node (/server.js) 
// This is our api model that connects us to mongoose (see /db.js)
var db = require('../db')
var Post = db.model('Post', {
  name: { type: String, required: true},       
  ip: { type: String, required: true }
});
module.exports = Post

