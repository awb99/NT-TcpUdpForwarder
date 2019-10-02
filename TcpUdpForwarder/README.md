

TcpUdpForwarder can run in 2 modes

1. Service Mode:
   Enabled by starting in command line with "-svc" parameter.
   Runs without UI and does the forwarding
   
2. UI Mode:
   This UI will connect to the management port, and will send commands to the controller. 


config.xml
    Configuration is in config.xml which has to be in the same directory as the app).
    All Forwarders work for Both TCP and UDP.
    Multiple Server Elements create multiple servers.


Logfile:
   /tmp/TcpUdpForwarder.log   (could be other directory on windows)
   
   