#!/bin/bash

curl -v -H "Content-Type: application/json" -XPOST --data "{\"username\":\"Administrator\",\"sitename\":\"Wonder Corp.\",\"machinename\":\"Production Application VM 1\",\"machinedescription\":\"The primary application server instance.\",\"domainname\":\"WCI\",\"ipaddress\":\"192.168.1.100\",\"lastloginuser\":\"Paul\",\"lastlogintimestamp\":\"32 August 2002\",\"lastloginip\":\"168.168.10.10\",\"lastlogout\":\"33 August 2003\",\"isavailable\":\"YES\"}" localhost:8000/api/updateconnection
