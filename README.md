## Get started
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
