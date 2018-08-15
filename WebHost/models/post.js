// Called by Node (/server.js) 
// This is our api model that connects us to mongoose (see /db.js)
var db = require('../db')
var Post = db.model('Post', {
  col_1: { type: String, required: true},       
  col_2: { type: String, required: true },    
  col_3: { type: String, required: true },
  col_4: { type: String, required: true },
  col_5: { type: String, required: true },
  col_6: { type: String, required: true }    
});
module.exports = Post

