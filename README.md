#Get started
##Installing Docker
On Windows you have two options: either install Docker Toolbox which includes docker-machine which is a tool to create docker hosts and install docker engine in the hosts. Or you can manually create a Linux virtual machine in which you install docker engine manually (see below).

###Install using Docker Toolbox
Download docker toolbox [here](https://www.docker.com/docker-toolbox)
The installation will include a couple of optional installations. If you already have e.g. Git for Windows or e.g. VirtualBox, un-check them.
I've hade very little luck to get the Docker CLI working properly on Windows so I prefer to use docker-machine instead.
Here's how you would create a docker host with docker engine: start a Windows command prompt and type `docker-machine create -d virtualbox my-docker-host`
When it's created you can ssh in to the host: `docker-machine ssh my-docker-host`
Try the following: `docker run -d -p 80:80 nginx`. This will download and run the official nginx image in a container. `-d` runs it in the background and `-p 80:80` forwards port 80 in the container to port 80 on the host. Do `docker ps` which will list the running containers.
Now type `exit` to get back to the Windows command line. Type `docker-machine list` and note the ip-address of the my-docker-host. Type the ip address into a web browser's address field and hit enter. The nginx welcome page should appear.

###Install using a Linux virtual machine
* Download and install VirtualBox: https://www.virtualbox.org/wiki/Downloads
* Download and install Vagrant: https://www.vagrantup.com/downloads.html
* Open bash and clone this repo (bash makes it easier to work with vagrant. Installed with [Git for Windows](https://git-for-windows.github.io/))
* Do `vagrant up` which creates an Ubuntu vm 
* Do `vagrant ssh` which logs you into the VM
* Install Docker on the Ubuntu machine: https://docs.docker.com/engine/installation/ubuntulinux/<br/>
  **tl;dr**
  * `sudo apt-key adv --keyserver hkp://p80.pool.sks-keyservers.net:80 --recv-keys 58118E89F3A912897C070ADBF76221572C52609D`
  * Open /etc/apt/sources.list.d/docker.list in e.g. Vim
  * Insert `deb https://apt.dockerproject.org/repo ubuntu-trusty main` and then save & close
  * `sudo apt-get update`
  * `sudo apt-get install linux-image-extra-$(uname -r)` (The linux-image-extra package allows you use the aufs storage driver.)
  * `sudo apt-get install docker-engine`
  * Verify installation: `sudo docker run hello-world`
* To not have to run docker priviledged, add vagrant user to docker group: `sudo usermod -aG docker vagrant` and then log out and in again (`exit` and then `vagrant ssh`)
