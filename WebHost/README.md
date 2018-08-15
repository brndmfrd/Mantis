This is the accompanying server host.
The job of the host is to expose an api for the client.
The host serves information upon request to the client(s).

The app uses node and npm.

===================
Common Commands
===================
----------------------
launch server instance
----------------------
$nodejs server.js


--------------------
Install dependencies
--------------------
$npm install


====================
Setup
====================
== Setup ==
# Use NPM to install Express JS
    mkdir app
    cd app     
    npm init
    <follow promps>
    npm install express --save

# Use NPM to install Angular JS
    npm install angular --save

# Use NPM to install BodyParser
    npm install body-parser

# Use NPM to install Mongoose 
    npm install mongoose

# SELinux permission for mongo
    sudo yum provides semanage
    sudo yum -y install policycoreutils	
    sudo semanage port -a -t mongod_port_t -p tcp 27017

# Install Mongo
    <from website -- for RedHat (actual CentOS7)
    create file /etc/yum.repos.d/mongodb-org-2.6.repo
    add to file
    	[mongodb-org-2.6]
	name=MongoDB 2.6 Repository
	baseurl=http://downloads-distro.mongodb.org/repo/redhat/os/x86_64/
	gpgcheck=0
	enabled=1
    sudo yum install -y mongodb-org

# Start Mongo
    sudo service mongod start

# Set mongo to start when system starts
    sudo chkconfig mongod on

# Install Morgan (logger)
    npm install morgan --save