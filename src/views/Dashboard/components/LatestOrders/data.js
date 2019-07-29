import uuid from 'uuid/v1';

export default [
  {
    id: uuid(),
    SERVER_name_friendly: 'Builders Mayhem',
    SERVER_type: 'Garrys Mod',
    MEMORY_Usage: '2.2GB',
    DISK_Usage: '2.2GB',
    CPU_Usage: '5.2 %',
    NETWORK_Usage: '40.0 mbps',
    SERVER_auto_restart: 'Enabled',
    status: 'Running'
  },
  {
    id: uuid(),
    SERVER_name_friendly: 'To the Nether!',
    SERVER_type: 'Minecraft',
    MEMORY_Usage: '2.0GB',
    DISK_Usage: '4.0GB',
    CPU_Usage: '2.0 %',
    NETWORK_Usage: '3.9 mbps',
    SERVER_auto_restart: 'Enabled',
    status: 'Running'
  },
  {
    id: uuid(),
    SERVER_name_friendly: 'Insanity Runners',
    SERVER_type: 'Half-Life 2: Deathmatch',
    MEMORY_Usage: '20.2GB',
    DISK_Usage: '12.1GB',
    CPU_Usage: '15.0 %',
    NETWORK_Usage: '18.2 mbps',
    SERVER_auto_restart: 'Disabled',
    status: 'Starting'
  },
  {
    id: uuid(),
    SERVER_name_friendly: 'Killing Floor Massacre',
    SERVER_type: 'Killing Floor 2',
    MEMORY_Usage: '3.0GB',
    DISK_Usage: '12.1GB',
    CPU_Usage: '15.0 %',
    NETWORK_Usage: '2.2 mbps',
    SERVER_auto_restart: 'Disabled',
    status: 'Stopped'
  }
];
