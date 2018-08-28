// Called by Node (/server.js) 
// This is our api model that connects us to mongoose (see /db.js)
var db = require('../db')
var Post = db.model('Post', {
    username: { type: String, required: true},       
    sitename: { type: String, required: true }
    machinename: { type: String, required: true }
    machinedescription: { type: String, required: true }
    domainname: { type: String, required: true }
    ipaddress: { type: String, required: true }
    lastloginuser: { type: String, required: true }
    lastlogintimestamp: { type: String, required: true }
    lastloginip: { type: String, required: true }
    lastlogout: { type: String, required: true }
    isavailable: { type: String, required: true }
});
module.exports = Post

