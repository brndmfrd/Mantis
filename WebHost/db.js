var mongoose = require('mongoose')

mongoose.connect('mongodb://localhost/connections', function () {
  console.log('mongodb connected')
})
module.exports = mongoose

