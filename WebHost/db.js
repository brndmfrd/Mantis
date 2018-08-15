var mongoose = require('mongoose')

mongoose.connect('mongodb://localhost/inventory', function () {
  console.log('mongodb connected')
})
module.exports = mongoose

