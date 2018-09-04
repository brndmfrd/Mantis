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
# Install node/nodejs
  (deb/ubu) - installs nodejs, includes npm
  curl -sL https://deb.nodesource.com/setup_10.x | sudo bash -

# The following "npm install ..." commands are equivalent to
  npm install
  # Use this to install dependencies listed in package.json (same lvl dir)

# Use NPM to install Express JS (manual)
    mkdir app
    cd app
    npm init
    <follow promps>
    npm install express --save

# Use NPM to install Angular JS (manual)
    npm install angular --save

# Use NPM to install BodyParser(manual)
    npm install body-parser

# Use NPM to install Mongoose (manual)
    npm install mongoose

# SELinux permission for mongo
    sudo yum provides semanage
    sudo yum -y install policycoreutils
    sudo semanage port -a -t mongod_port_t -p tcp 27017

# Mongo pkg - Add package repo to ubutu
  sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv 2930ADAE8CAF5059EE73BB4B58712A2291FA4AD5
  echo "deb [ arch=amd64,arm64 ] https://repo.mongodb.org/apt/ubuntu xenial/mongodb-org/3.6 multiverse" | sudo tee /etc/apt/sources.list.d/mongodb-org-3.6.list

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

# Install Mongo (Ubuntu 18.04)
  sudo apt install -y mongodb

# Enable Mongo (ubu)
  sudo systemctl enable mongod.service

# View status (ubu)
  sudo systemctl status mongod

# Start Mongo
    (CentOS) sudo service mongod start
    (Ubu1804) sudo systemctl start mongodb

# Set mongo to start when system starts
    (CEntOS) sudo chkconfig mongod on
    (Ubu1804) <configured by default>

# Install Morgan (manual)
