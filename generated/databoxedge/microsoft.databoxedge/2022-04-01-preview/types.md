# Microsoft.DataBoxEdge @ 2022-04-01-preview

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **etag**: string: The etag for the devices.
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **identity**: [ResourceIdentity](#resourceidentity): Msi identity of the resource
* **kind**: 'AzureDataBoxGateway' | 'AzureModularDataCentre' | 'AzureStackEdge' | 'AzureStackHub' | string: The kind of the device.
* **location**: string (Required): The location of the device. This is a supported and registered Azure geographical region (for example, West US, East US, or Southeast Asia). The geographical region of a device cannot be changed once it is created, but if an identical geographical region is specified on update, the request will succeed.
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [DataBoxEdgeDeviceProperties](#databoxedgedeviceproperties): The properties of the Data Box Edge/Gateway device.
* **sku**: [Sku](#sku): The SKU type.
* **systemData**: [SystemData](#systemdata) (ReadOnly): DataBoxEdge Resource
* **tags**: [DataBoxEdgeDeviceTags](#databoxedgedevicetags): The list of tags that describe the device. These tags can be used to view and group this device (across resource groups).
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/alerts@2022-04-01-preview (ReadOnly)
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [AlertProperties](#alertproperties) (ReadOnly): Properties of alert.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Alert
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/alerts' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/bandwidthSchedules@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [BandwidthScheduleProperties](#bandwidthscheduleproperties) (Required): The properties of the bandwidth schedule.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of BandwidthSchedule
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/bandwidthSchedules' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/deviceCapacityInfo@2022-04-01-preview (ReadOnly)
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [DeviceCapacityInfoProperties](#devicecapacityinfoproperties) (ReadOnly): The device capacity properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to device capacity info.
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/deviceCapacityInfo' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/diagnosticProactiveLogCollectionSettings@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [ProactiveLogCollectionSettingsProperties](#proactivelogcollectionsettingsproperties) (Required): Properties of the diagnostic proactive log collection settings.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of DiagnosticProactiveLogCollectionSettings
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/diagnosticProactiveLogCollectionSettings' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/diagnosticRemoteSupportSettings@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [DiagnosticRemoteSupportSettingsProperties](#diagnosticremotesupportsettingsproperties) (Required): Properties of the remote support  settings.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Represents resource creation and updation time
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/diagnosticRemoteSupportSettings' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/networkSettings@2022-04-01-preview (ReadOnly)
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [NetworkSettingsProperties](#networksettingsproperties) (ReadOnly): The properties of network settings of a device.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of NetworkSettings
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/networkSettings' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **kind**: string (ReadOnly): It specify the order api version.
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [OrderProperties](#orderproperties): The order properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Order
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
* **Discriminator**: kind

### Base Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Role
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles' (ReadOnly, DeployTimeConstant): The resource type

### CloudEdgeManagementRole
#### Properties
* **kind**: 'CloudEdgeManagement' (Required): Role type.
* **properties**: [CloudEdgeManagementRoleProperties](#cloudedgemanagementroleproperties): Properties specific to CloudEdgeManagementRole role.

### IoTRole
#### Properties
* **kind**: 'IOT' (Required): Role type.
* **properties**: [IoTRoleProperties](#iotroleproperties): Properties specific to IoT role.

### KubernetesRole
#### Properties
* **kind**: 'Kubernetes' (Required): Role type.
* **properties**: [KubernetesRoleProperties](#kubernetesroleproperties): Properties specific to Kubernetes role.

### MECRole
#### Properties
* **kind**: 'MEC' (Required): Role type.
* **properties**: [MECRoleProperties](#mecroleproperties): Properties specific to MEC role.


## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles/addons@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
* **Discriminator**: kind

### Base Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Addon
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles/addons' (ReadOnly, DeployTimeConstant): The resource type

### ArcAddon
#### Properties
* **kind**: 'ArcForKubernetes' (Required): Addon type.
* **properties**: [ArcAddonProperties](#arcaddonproperties) (Required): Properties specific to Arc addon.


## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles/monitoringConfig@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [MonitoringMetricConfigurationProperties](#monitoringmetricconfigurationproperties) (Required): The metric setting properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of MonitoringConfiguration
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles/monitoringConfig' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/shares@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [ShareProperties](#shareproperties) (Required): The share properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Share
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/shares' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [StorageAccountCredentialProperties](#storageaccountcredentialproperties) (Required): The storage account credential properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of StorageAccountCredential
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccounts@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [StorageAccountProperties](#storageaccountproperties) (Required): The Storage Account properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of StorageAccount
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccounts' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccounts/containers@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [ContainerProperties](#containerproperties) (Required): The container properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Container
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccounts/containers' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/triggers@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
* **Discriminator**: kind

### Base Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of Trigger
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/triggers' (ReadOnly, DeployTimeConstant): The resource type

### FileEventTrigger
#### Properties
* **kind**: 'FileEvent' (Required): Trigger Kind.
* **properties**: [FileTriggerProperties](#filetriggerproperties) (Required): File trigger properties.

### PeriodicTimerEventTrigger
#### Properties
* **kind**: 'PeriodicTimerEvent' (Required): Trigger Kind.
* **properties**: [PeriodicTimerProperties](#periodictimerproperties) (Required): Periodic timer trigger properties.


## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/updateSummary@2022-04-01-preview (ReadOnly)
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: 'default' (Required, DeployTimeConstant): The resource name
* **properties**: [UpdateSummaryProperties](#updatesummaryproperties) (ReadOnly): The device update information summary.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of UpdateSummary
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/updateSummary' (ReadOnly, DeployTimeConstant): The resource type

## Resource Microsoft.DataBoxEdge/dataBoxEdgeDevices/users@2022-04-01-preview
* **Valid Scope(s)**: ResourceGroup
### Properties
* **apiVersion**: '2022-04-01-preview' (ReadOnly, DeployTimeConstant): The resource api version
* **id**: string (ReadOnly, DeployTimeConstant): The resource id
* **name**: string (Required, DeployTimeConstant): The resource name
* **properties**: [UserProperties](#userproperties) (Required): The storage account credential properties.
* **systemData**: [SystemData](#systemdata) (ReadOnly): Metadata pertaining to creation and last modification of User
* **type**: 'Microsoft.DataBoxEdge/dataBoxEdgeDevices/users' (ReadOnly, DeployTimeConstant): The resource type

## Function listDCAccessCode (Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders@2022-04-01-preview)
* **Resource**: Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders
* **ApiVersion**: 2022-04-01-preview
* **Output**: [DCAccessCode](#dcaccesscode)

## Address
### Properties
* **addressLine1**: string: The address line1.
* **addressLine2**: string: The address line2.
* **addressLine3**: string: The address line3.
* **city**: string: The city name.
* **country**: string (Required): The country name.
* **postalCode**: string: The postal code.
* **state**: string: The state name.

## AlertErrorDetails
### Properties
* **errorCode**: string (ReadOnly): Error code.
* **errorMessage**: string (ReadOnly): Error Message.
* **occurrences**: int (ReadOnly): Number of occurrences.

## AlertProperties
### Properties
* **alertType**: string (ReadOnly): Alert type.
* **appearedAtDateTime**: string (ReadOnly): UTC time when the alert appeared.
* **detailedInformation**: [AlertPropertiesDetailedInformation](#alertpropertiesdetailedinformation) (ReadOnly): Alert details.
* **errorDetails**: [AlertErrorDetails](#alerterrordetails) (ReadOnly): Error details of the alert.
* **recommendation**: string (ReadOnly): Alert recommendation.
* **severity**: 'Critical' | 'Informational' | 'Warning' | string (ReadOnly): Severity of the alert.
* **title**: string (ReadOnly): Alert title.

## AlertPropertiesDetailedInformation
### Properties
### Additional Properties
* **Additional Properties Type**: string

## ArcAddonProperties
### Properties
* **hostPlatform**: 'Linux' | 'Windows' | string (ReadOnly): Host OS supported by the Arc addon.
* **hostPlatformType**: 'KubernetesCluster' | 'LinuxVM' | string (ReadOnly): Platform where the runtime is hosted.
* **provisioningState**: 'Created' | 'Creating' | 'Deleting' | 'Failed' | 'Invalid' | 'Reconfiguring' | 'Updating' | string (ReadOnly): Addon Provisioning State
* **resourceGroupName**: string (Required): Arc resource group name
* **resourceLocation**: string (Required): Arc resource location
* **resourceName**: string (Required): Arc resource Name
* **subscriptionId**: string (Required): Arc resource subscription Id
* **version**: string (ReadOnly): Arc resource version

## AsymmetricEncryptedSecret
### Properties
* **encryptionAlgorithm**: 'AES256' | 'None' | 'RSAES_PKCS1_v_1_5' | string (Required): The algorithm used to encrypt "Value".
* **encryptionCertThumbprint**: string: Thumbprint certificate used to encrypt \"Value\". If the value is unencrypted, it will be null.
* **value**: string (Required): The value of the secret.

## Authentication
### Properties
* **symmetricKey**: [SymmetricKey](#symmetrickey): Symmetric key for authentication.

## AzureContainerInfo
### Properties
* **containerName**: string (Required): Container name (Based on the data format specified, this represents the name of Azure Files/Page blob/Block blob).
* **dataFormat**: 'AzureFile' | 'BlockBlob' | 'PageBlob' | string (Required): Storage format used for the file represented by the share.
* **storageAccountCredentialId**: string (Required): ID of the storage account credential used to access storage.

## BandwidthScheduleProperties
### Properties
* **days**: 'Friday' | 'Monday' | 'Saturday' | 'Sunday' | 'Thursday' | 'Tuesday' | 'Wednesday' | string[] (Required): The days of the week when this schedule is applicable.
* **rateInMbps**: int (Required): The bandwidth rate in Mbps.
* **start**: string (Required): The start time of the schedule in UTC.
* **stop**: string (Required): The stop time of the schedule in UTC.

## ClientAccessRight
### Properties
* **accessPermission**: 'NoAccess' | 'ReadOnly' | 'ReadWrite' | string (Required): Type of access to be allowed for the client.
* **client**: string (Required): IP of the client.

## CloudEdgeManagementRoleProperties
### Properties
* **edgeProfile**: [EdgeProfile](#edgeprofile) (ReadOnly): Edge Profile of the resource
* **localManagementStatus**: 'Disabled' | 'Enabled' | string (ReadOnly): Local Edge Management Status
* **roleStatus**: 'Disabled' | 'Enabled' | string (Required): Role status.

## ClusterCapacityViewData
### Properties
* **fqdn**: string: The FQDN of the cluster.
* **gpuCapacity**: [ClusterGpuCapacity](#clustergpucapacity): The cluster's GPU capacity.
* **lastRefreshedTime**: string: The last time at which the ClusterCapacityViewData was set.
* **memoryCapacity**: [ClusterMemoryCapacity](#clustermemorycapacity): The cluster's memory capacity.
* **totalProvisionedNonHpnCores**: int: The total # of vCPUs provisioned by non-HPN VM per appliance.

## ClusterGpuCapacity
### Properties
* **gpuFreeUnitsCount**: int: The free GPU units count in the cluster.
* **gpuReservedForFailoverUnitsCount**: int: The GPU units count reserved for failover in the cluster.
* **gpuTotalUnitsCount**: int: The total GPU units count in the cluster.
* **gpuType**: string: The cluster GPU Type.
* **gpuUsedUnitsCount**: int: The used GPU units count in the cluster.

## ClusterMemoryCapacity
### Properties
* **clusterFailoverMemoryMb**: int: The failover memory in the cluster in MB.
* **clusterFragmentationMemoryMb**: int: The fragmentation memory in the cluster in MB.
* **clusterFreeMemoryMb**: int: The free memory in the cluster in MB.
* **clusterHypervReserveMemoryMb**: int: The memory reserved for Hyper-V in the cluster in MB.
* **clusterInfraVmMemoryMb**: int: The memory of the Infra VM in the cluster in MB.
* **clusterMemoryUsedByVmsMb**: int: The memory used by VMs in the cluster in MB.
* **clusterNonFailoverVmMb**: int: The non-failover memory in the cluster in MB.
* **clusterTotalMemoryMb**: int: The total memory in the cluster in MB.
* **clusterUsedMemoryMb**: int: The used memory in the cluster in MB.

## ClusterStorageViewData
### Properties
* **clusterFreeStorageMb**: int: The available or free storage on the cluster in MB.
* **clusterTotalStorageMb**: int: Total storage on the cluster in MB.

## CniConfig
### Properties
* **componentType**: 'CNI' | 'Cluster' | 'Etcd' | 'Invalid' | 'LoadBalancer' | 'Node' | string (ReadOnly): ComponentType of the Kubernetes node.
* **podSubnet**: string (ReadOnly): Pod Subnet
* **serviceSubnet**: string (ReadOnly): Service subnet
* **type**: string (ReadOnly): Cni type
* **version**: string (ReadOnly): Cni version

## ComputeResource
### Properties
* **memoryInGB**: int (Required): Memory in GB
* **processorCount**: int (Required): Processor count

## ComputeVersionInformation
### Properties
* **azureArcVersion**: string: Azure Arc Version
* **iotEdgeVersion**: string: IOTEdge Version
* **kubernetesVersion**: string: Kubernetes Version

## ContactDetails
### Properties
* **companyName**: string (Required): The name of the company.
* **contactPerson**: string (Required): The contact person name.
* **emailList**: string[] (Required): The email list.
* **phone**: string (Required): The phone number.

## ContainerProperties
### Properties
* **containerStatus**: 'NeedsAttention' | 'OK' | 'Offline' | 'Unknown' | 'Updating' | string (ReadOnly): Current status of the container.
* **createdDateTime**: string (ReadOnly): The UTC time when container got created.
* **dataFormat**: 'AzureFile' | 'BlockBlob' | 'PageBlob' | string (Required): DataFormat for Container
* **refreshDetails**: [RefreshDetails](#refreshdetails) (ReadOnly): Details of the refresh job on this container.

## DataBoxEdgeDeviceProperties
### Properties
* **computeVersionInformation**: [ComputeVersionInformation](#computeversioninformation) (ReadOnly): The details of compute version information
* **configuredRoleTypes**: 'ASA' | 'CloudEdgeManagement' | 'Cognitive' | 'Functions' | 'IOT' | 'Kubernetes' | 'MEC' | string[] (ReadOnly): Type of compute roles configured.
* **culture**: string (ReadOnly): The Data Box Edge/Gateway device culture.
* **dataBoxEdgeDeviceStatus**: 'Disconnected' | 'Maintenance' | 'NeedsAttention' | 'Offline' | 'Online' | 'PartiallyDisconnected' | 'ReadyToSetup' | string: The status of the Data Box Edge/Gateway device.
* **dataResidency**: [DataResidency](#dataresidency): The details of data-residency related properties for this resource
* **description**: string (ReadOnly): The Description of the Data Box Edge/Gateway device.
* **deviceHcsVersion**: string (ReadOnly): The device software version number of the device (eg: 1.2.18105.6).
* **deviceLocalCapacity**: int (ReadOnly): The Data Box Edge/Gateway device local capacity in MB.
* **deviceModel**: string (ReadOnly): The Data Box Edge/Gateway device model.
* **deviceSoftwareVersion**: string (ReadOnly): The Data Box Edge/Gateway device software version.
* **deviceType**: 'DataBoxEdgeDevice' | string (ReadOnly): The type of the Data Box Edge/Gateway device.
* **edgeProfile**: [EdgeProfile](#edgeprofile) (ReadOnly): The details of Edge Profile for this resource
* **friendlyName**: string (ReadOnly): The Data Box Edge/Gateway device name.
* **kubernetesPlatform**: string (ReadOnly): Type of Kubernetes Platform
* **modelDescription**: string (ReadOnly): The description of the Data Box Edge/Gateway device model.
* **nodeCount**: int (ReadOnly): The number of nodes in the cluster.
* **resourceMoveDetails**: [ResourceMoveDetails](#resourcemovedetails) (ReadOnly): The details of the move operation on this resource.
* **serialNumber**: string (ReadOnly): The Serial Number of Data Box Edge/Gateway device.
* **systemData**: [SystemData](#systemdata) (ReadOnly): DataBoxEdge Device Properties
* **timeZone**: string (ReadOnly): The Data Box Edge/Gateway device timezone.

## DataBoxEdgeDeviceTags
### Properties
### Additional Properties
* **Additional Properties Type**: string

## DataResidency
### Properties
* **type**: 'GeoZoneReplication' | 'ZoneReplication' | string: DataResidencyType enum

## DCAccessCode
### Properties
* **properties**: [DCAccessCodeProperties](#dcaccesscodeproperties): DCAccessCode properties.

## DCAccessCodeProperties
### Properties
* **authCode**: string: DCAccess Code for the Self Managed shipment.

## DeviceCapacityInfoProperties
### Properties
* **clusterComputeCapacityInfo**: [ClusterCapacityViewData](#clustercapacityviewdata): Cluster capacity data for compute resources (Memory and GPU).
* **clusterStorageCapacityInfo**: [ClusterStorageViewData](#clusterstorageviewdata): Cluster capacity data for storage resources (CSV).
* **nodeCapacityInfos**: [DeviceCapacityInfoPropertiesNodeCapacityInfos](#devicecapacityinfopropertiesnodecapacityinfos): The dictionary of individual node names and node capacities in the cluster.
* **timeStamp**: string: Timestamp of request in UTC

## DeviceCapacityInfoPropertiesNodeCapacityInfos
### Properties
### Additional Properties
* **Additional Properties Type**: [HostCapacity](#hostcapacity)

## DiagnosticRemoteSupportSettingsProperties
### Properties
* **remoteSupportSettingsList**: [RemoteSupportSettings](#remotesupportsettings)[]: Remote support settings list according to the RemoteApplicationType

## EdgeProfile
### Properties
* **subscription**: [EdgeProfileSubscription](#edgeprofilesubscription): Edge Profile Subscription

## EdgeProfileSubscription
### Properties
* **id**: string: ARM ID of the subscription
* **properties**: [SubscriptionProperties](#subscriptionproperties)
* **registrationDate**: string
* **registrationId**: string: Edge Subscription Registration ID
* **state**: 'Deleted' | 'Registered' | 'Suspended' | 'Unregistered' | 'Warned' | string
* **subscriptionId**: string

## EtcdInfo
### Properties
* **componentType**: 'CNI' | 'Cluster' | 'Etcd' | 'Invalid' | 'LoadBalancer' | 'Node' | string (ReadOnly): ComponentType of the Kubernetes node.
* **type**: string (ReadOnly): Etcd type
* **version**: string (ReadOnly): Etcd version

## FileSourceInfo
### Properties
* **shareId**: string (Required): File share ID.

## FileTriggerProperties
### Properties
* **customContextTag**: string: A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module.
* **sinkInfo**: [RoleSinkInfo](#rolesinkinfo) (Required): Role sink info.
* **sourceInfo**: [FileSourceInfo](#filesourceinfo) (Required): File event source details.

## HostCapacity
### Properties
* **availableGpuCount**: int: The available amount of GPUs on the host to use after accounting for GPUS used by reservations on the host.
* **effectiveAvailableMemoryMbOnHost**: int: The available memory on the host accounting for VM placement size and any host VM reservations.
* **gpuType**: string: The GPU type of the VM.
* **hostName**: string: The name of the host.
* **numaNodesData**: [NumaNodeData](#numanodedata)[]: The numa nodes information for Hpn VMs.
* **vmUsedMemory**: [HostCapacityVmUsedMemory](#hostcapacityvmusedmemory): The VM used memory per VmId.

## HostCapacityVmUsedMemory
### Properties
### Additional Properties
* **Additional Properties Type**: [VmMemory](#vmmemory)

## ImageRepositoryCredential
### Properties
* **imageRepositoryUrl**: string (Required): Image repository url (e.g.: mcr.microsoft.com).
* **password**: [AsymmetricEncryptedSecret](#asymmetricencryptedsecret): Repository user password.
* **userName**: string (Required): Repository user name.

## IoTDeviceInfo
### Properties
* **authentication**: [Authentication](#authentication): Encrypted IoT device/IoT edge device connection string.
* **deviceId**: string (Required): ID of the IoT device/edge device.
* **ioTHostHub**: string (Required): Host name for the IoT hub associated to the device.
* **ioTHostHubId**: string: Id for the IoT hub associated to the device.

## IoTEdgeAgentInfo
### Properties
* **imageName**: string (Required): Name of the IoT edge agent image.
* **imageRepository**: [ImageRepositoryCredential](#imagerepositorycredential): Image repository details.
* **tag**: string (Required): Image Tag.

## IoTRoleProperties
### Properties
* **computeResource**: [ComputeResource](#computeresource): Resource allocation
* **hostPlatform**: 'Linux' | 'Windows' | string (Required): Host OS supported by the IoT role.
* **hostPlatformType**: 'KubernetesCluster' | 'LinuxVM' | string (ReadOnly): Platform where the Iot runtime is hosted.
* **ioTDeviceDetails**: [IoTDeviceInfo](#iotdeviceinfo) (Required): IoT device metadata to which data box edge device needs to be connected.
* **ioTEdgeAgentInfo**: [IoTEdgeAgentInfo](#iotedgeagentinfo): Iot edge agent details to download the agent and bootstrap iot runtime.
* **ioTEdgeDeviceDetails**: [IoTDeviceInfo](#iotdeviceinfo) (Required): IoT edge device to which the IoT role needs to be configured.
* **roleStatus**: 'Disabled' | 'Enabled' | string (Required): Role status.
* **shareMappings**: [MountPointMap](#mountpointmap)[]: Mount points of shares in role(s).

## Ipv4Config
### Properties
* **gateway**: string (ReadOnly): The IPv4 gateway of the network adapter.
* **ipAddress**: string (ReadOnly): The IPv4 address of the network adapter.
* **subnet**: string (ReadOnly): The IPv4 subnet of the network adapter.

## Ipv6Config
### Properties
* **gateway**: string (ReadOnly): The IPv6 gateway of the network adapter.
* **ipAddress**: string (ReadOnly): The IPv6 address of the network adapter.
* **prefixLength**: int (ReadOnly): The IPv6 prefix of the network adapter.

## KubernetesClusterInfo
### Properties
* **componentType**: 'CNI' | 'Cluster' | 'Etcd' | 'Invalid' | 'LoadBalancer' | 'Node' | string (ReadOnly): ComponentType of the Kubernetes node.
* **etcdInfo**: [EtcdInfo](#etcdinfo) (ReadOnly): Etcd configuration
* **nodes**: [NodeInfo](#nodeinfo)[] (ReadOnly): Kubernetes cluster nodes
* **version**: string (Required): Kubernetes cluster version

## KubernetesIPConfiguration
### Properties
* **ipAddress**: string: IP address of the Kubernetes node.
* **port**: string (ReadOnly): Port of the Kubernetes node.

## KubernetesRoleCompute
### Properties
* **hugePage1G**: int (ReadOnly): Count of huge pages
* **hugePage2M**: int (ReadOnly): Count of huge pages
* **memoryInBytes**: int (ReadOnly): Memory in bytes
* **processorCount**: int (ReadOnly): Processor count
* **vmProfile**: string (Required): VM profile

## KubernetesRoleNetwork
### Properties
* **cniConfig**: [CniConfig](#cniconfig) (ReadOnly): Cni configuration
* **loadBalancerConfig**: [LoadBalancerConfig](#loadbalancerconfig) (ReadOnly): Load balancer configuration

## KubernetesRoleProperties
### Properties
* **hostPlatform**: 'Linux' | 'Windows' | string (Required): Host OS supported by the Kubernetes role.
* **hostPlatformType**: 'KubernetesCluster' | 'LinuxVM' | string (ReadOnly): Platform where the runtime is hosted.
* **kubernetesClusterInfo**: [KubernetesClusterInfo](#kubernetesclusterinfo) (Required): Kubernetes cluster configuration
* **kubernetesRoleResources**: [KubernetesRoleResources](#kubernetesroleresources) (Required): Kubernetes role resources
* **provisioningState**: 'Created' | 'Creating' | 'Deleting' | 'Failed' | 'Invalid' | 'Reconfiguring' | 'Updating' | string (ReadOnly): State of Kubernetes deployment
* **roleStatus**: 'Disabled' | 'Enabled' | string (Required): Role status.

## KubernetesRoleResources
### Properties
* **compute**: [KubernetesRoleCompute](#kubernetesrolecompute) (Required): Kubernetes role compute resource
* **network**: [KubernetesRoleNetwork](#kubernetesrolenetwork) (ReadOnly): Kubernetes role network resource
* **storage**: [KubernetesRoleStorage](#kubernetesrolestorage): Kubernetes role storage resource

## KubernetesRoleStorage
### Properties
* **endpoints**: [MountPointMap](#mountpointmap)[]: Mount points of shares in role(s).
* **storageClasses**: [KubernetesRoleStorageClassInfo](#kubernetesrolestorageclassinfo)[] (ReadOnly): Kubernetes storage class info.

## KubernetesRoleStorageClassInfo
### Properties
* **name**: string (ReadOnly): Storage class name.
* **posixCompliant**: 'Disabled' | 'Enabled' | 'Invalid' | string (ReadOnly): If provisioned storage is posix compliant.
* **type**: string (ReadOnly): Storage class type.

## LoadBalancerConfig
### Properties
* **componentType**: 'CNI' | 'Cluster' | 'Etcd' | 'Invalid' | 'LoadBalancer' | 'Node' | string (ReadOnly): ComponentType of the Kubernetes node.
* **type**: string (ReadOnly): Load balancer type
* **version**: string (ReadOnly): Load balancer version

## MECRoleProperties
### Properties
* **connectionString**: [AsymmetricEncryptedSecret](#asymmetricencryptedsecret): Activation key of the MEC.
* **controllerEndpoint**: string: Controller Endpoint.
* **resourceUniqueId**: string: Unique Id of the Resource.
* **roleStatus**: 'Disabled' | 'Enabled' | string (Required): Role status.

## MetricConfiguration
### Properties
* **counterSets**: [MetricCounterSet](#metriccounterset)[] (Required): Host name for the IoT hub associated to the device.
* **mdmAccount**: string: The MDM account to which the counters should be pushed.
* **metricNameSpace**: string: The MDM namespace to which the counters should be pushed. This is required if MDMAccount is specified
* **resourceId**: string (Required): The Resource ID on which the metrics should be pushed.

## MetricCounter
### Properties
* **additionalDimensions**: [MetricDimension](#metricdimension)[]: The additional dimensions to be added to metric.
* **dimensionFilter**: [MetricDimension](#metricdimension)[]: The dimension filter.
* **instance**: string: The instance from which counter should be collected.
* **name**: string (Required): The counter name.

## MetricCounterSet
### Properties
* **counters**: [MetricCounter](#metriccounter)[] (Required): The counters that should be collected in this set.

## MetricDimension
### Properties
* **sourceName**: string (Required): The dimension value.
* **sourceType**: string (Required): The dimension type.

## MonitoringMetricConfigurationProperties
### Properties
* **metricConfigurations**: [MetricConfiguration](#metricconfiguration)[] (Required): The metrics configuration details

## MountPointMap
### Properties
* **mountPoint**: string (ReadOnly): Mount point for the share.
* **mountType**: 'HostPath' | 'Volume' | string (ReadOnly): Mounting type.
* **roleId**: string (ReadOnly): ID of the role to which share is mounted.
* **roleType**: 'ASA' | 'CloudEdgeManagement' | 'Cognitive' | 'Functions' | 'IOT' | 'Kubernetes' | 'MEC' | string (ReadOnly): Role type.
* **shareId**: string (Required): ID of the share mounted to the role VM.

## NetworkAdapter
### Properties
* **adapterId**: string (ReadOnly): Instance ID of network adapter.
* **adapterPosition**: [NetworkAdapterPosition](#networkadapterposition) (ReadOnly): Hardware position of network adapter.
* **dhcpStatus**: 'Disabled' | 'Enabled' | string: Value indicating whether this adapter has DHCP enabled.
* **dnsServers**: string[] (ReadOnly): The list of DNS Servers of the device.
* **index**: int (ReadOnly): Logical index of the adapter.
* **ipv4Configuration**: [Ipv4Config](#ipv4config) (ReadOnly): The IPv4 configuration of the network adapter.
* **ipv6Configuration**: [Ipv6Config](#ipv6config) (ReadOnly): The IPv6 configuration of the network adapter.
* **ipv6LinkLocalAddress**: string (ReadOnly): The IPv6 local address.
* **label**: string (ReadOnly): Hardware label for the adapter.
* **linkSpeed**: int (ReadOnly): Link speed.
* **macAddress**: string (ReadOnly): MAC address.
* **networkAdapterName**: string (ReadOnly): Network adapter name.
* **nodeId**: string (ReadOnly): Node ID of the network adapter.
* **rdmaStatus**: 'Capable' | 'Incapable' | string: Value indicating whether this adapter is RDMA capable.
* **status**: 'Active' | 'Inactive' | string (ReadOnly): Value indicating whether this adapter is valid.

## NetworkAdapterPosition
### Properties
* **networkGroup**: 'NonRDMA' | 'None' | 'RDMA' | string (ReadOnly): The network group.
* **port**: int (ReadOnly): The port.

## NetworkSettingsProperties
### Properties
* **networkAdapters**: [NetworkAdapter](#networkadapter)[] (ReadOnly): The network adapter list on the device.

## NodeInfo
### Properties
* **componentType**: 'CNI' | 'Cluster' | 'Etcd' | 'Invalid' | 'LoadBalancer' | 'Node' | string (ReadOnly): ComponentType of the Kubernetes node.
* **ipConfiguration**: [KubernetesIPConfiguration](#kubernetesipconfiguration)[]: IP Configuration of the Kubernetes node.
* **name**: string (ReadOnly): Node name.
* **type**: 'ControlPlane' | 'Invalid' | 'ManagementCluster' | 'Master' | 'NodePool' | 'Worker' | string (ReadOnly): Node type - Master/Worker

## NumaNodeData
### Properties
* **effectiveAvailableMemoryInMb**: int: The effective available memory on the NUMA node in MB.
* **freeVCpuIndexesForHpn**: int[]: The free VCPU indices for the Hpn VMs.
* **logicalCoreCountPerCore**: int: The logical cores per core count.
* **numaNodeIndex**: int: The NUMA node index.
* **totalMemoryInMb**: int: The total memory on the NUMA node.
* **vCpuIndexesForHpn**: int[]: The VCPU indices for Hpn VMs
* **vCpuIndexesForRoot**: int[]: The VCPU indices for the root.

## OrderProperties
### Properties
* **contactInformation**: [ContactDetails](#contactdetails): The contact details.
* **currentStatus**: [OrderStatus](#orderstatus) (ReadOnly): Current status of the order.
* **deliveryTrackingInfo**: [TrackingInfo](#trackinginfo)[] (ReadOnly): Tracking information for the package delivered to the customer whether it has an original or a replacement device.
* **orderHistory**: [OrderStatus](#orderstatus)[] (ReadOnly): List of status changes in the order.
* **orderId**: string (ReadOnly): It specify the order resource id.
* **returnTrackingInfo**: [TrackingInfo](#trackinginfo)[] (ReadOnly): Tracking information for the package returned from the customer whether it has an original or a replacement device.
* **serialNumber**: string (ReadOnly): Serial number of the device.
* **shipmentType**: 'NotApplicable' | 'SelfPickup' | 'ShippedToCustomer' | string: ShipmentType of the order
* **shippingAddress**: [Address](#address): The shipping address.

## OrderStatus
### Properties
* **additionalOrderDetails**: [OrderStatusAdditionalOrderDetails](#orderstatusadditionalorderdetails) (ReadOnly): Dictionary to hold generic information which is not stored
by the already existing properties
* **comments**: string: Comments related to this status change.
* **status**: 'Arriving' | 'AwaitingDrop' | 'AwaitingFulfillment' | 'AwaitingPickup' | 'AwaitingPreparation' | 'AwaitingReturnShipment' | 'AwaitingShipment' | 'CollectedAtMicrosoft' | 'Declined' | 'Delivered' | 'LostDevice' | 'PickupCompleted' | 'ReplacementRequested' | 'ReturnInitiated' | 'Shipped' | 'ShippedBack' | 'Untracked' | string (Required): Status of the order as per the allowed status types.
* **trackingInformation**: [TrackingInfo](#trackinginfo) (ReadOnly): Tracking information related to the state in the ordering flow
* **updateDateTime**: string (ReadOnly): Time of status update.

## OrderStatusAdditionalOrderDetails
### Properties
### Additional Properties
* **Additional Properties Type**: string

## PeriodicTimerProperties
### Properties
* **customContextTag**: string: A custom context tag typically used to correlate the trigger against its usage. For example, if a periodic timer trigger is intended for certain specific IoT modules in the device, the tag can be the name or the image URL of the module.
* **sinkInfo**: [RoleSinkInfo](#rolesinkinfo) (Required): Role Sink information.
* **sourceInfo**: [PeriodicTimerSourceInfo](#periodictimersourceinfo) (Required): Periodic timer details.

## PeriodicTimerSourceInfo
### Properties
* **schedule**: string (Required): Periodic frequency at which timer event needs to be raised. Supports daily, hourly, minutes, and seconds.
* **startTime**: string (Required): The time of the day that results in a valid trigger. Schedule is computed with reference to the time specified upto seconds. If timezone is not specified the time will considered to be in device timezone. The value will always be returned as UTC time.
* **topic**: string: Topic where periodic events are published to IoT device.

## ProactiveLogCollectionSettingsProperties
### Properties
* **userConsent**: 'Disabled' | 'Enabled' | string (Required): Proactive diagnostic collection consent flag

## RefreshDetails
### Properties
* **errorManifestFile**: string: Indicates the relative path of the error xml for the last refresh job on this particular share or container, if any. This could be a failed job or a successful job.
* **inProgressRefreshJobId**: string: If a refresh job is currently in progress on this share or container, this field indicates the ARM resource ID of that job. The field is empty if no job is in progress.
* **lastCompletedRefreshJobTimeInUTC**: string: Indicates the completed time for the last refresh job on this particular share or container, if any.This could be a failed job or a successful job.
* **lastJob**: string: Indicates the id of the last refresh job on this particular share or container,if any. This could be a failed job or a successful job.

## RemoteSupportSettings
### Properties
* **accessLevel**: 'FullAccess' | 'None' | 'ReadOnly' | 'ReadWrite' | string: Access level allowed for this remote application type
* **expirationTimeStampInUTC**: string: Expiration time stamp
* **remoteApplicationType**: 'AllApplications' | 'LocalUI' | 'Powershell' | 'WAC' | string: Remote application type

## ResourceIdentity
### Properties
* **principalId**: string (ReadOnly): Service Principal Id backing the Msi
* **tenantId**: string (ReadOnly): Home Tenant Id
* **type**: 'None' | 'SystemAssigned' | 'UserAssigned' | string: Identity type

## ResourceMoveDetails
### Properties
* **operationInProgress**: 'None' | 'ResourceMoveFailed' | 'ResourceMoveInProgress' | string: Denotes whether move operation is in progress
* **operationInProgressLockTimeoutInUTC**: string: Denotes the timeout of the operation to finish

## RoleSinkInfo
### Properties
* **roleId**: string (Required): Compute role ID.

## ShareAccessRight
### Properties
* **accessType**: 'Change' | 'Custom' | 'Read' | string (Required): Type of access to be allowed on the share for this user.
* **shareId**: string (Required): The share ID.

## ShareProperties
### Properties
* **accessProtocol**: 'NFS' | 'SMB' | string (Required): Access protocol to be used by the share.
* **azureContainerInfo**: [AzureContainerInfo](#azurecontainerinfo): Azure container mapping for the share.
* **clientAccessRights**: [ClientAccessRight](#clientaccessright)[]: List of IP addresses and corresponding access rights on the share(required for NFS protocol).
* **dataPolicy**: 'Cloud' | 'Local' | string: Data policy of the share.
* **description**: string: Description for the share.
* **monitoringStatus**: 'Disabled' | 'Enabled' | string (Required): Current monitoring status of the share.
* **refreshDetails**: [RefreshDetails](#refreshdetails): Details of the refresh job on this share.
* **shareMappings**: [MountPointMap](#mountpointmap)[] (ReadOnly): Share mount point to the role.
* **shareStatus**: 'NeedsAttention' | 'OK' | 'Offline' | 'Unknown' | 'Updating' | string (Required): Current status of the share.
* **userAccessRights**: [UserAccessRight](#useraccessright)[]: Mapping of users and corresponding access rights on the share (required for SMB protocol).

## Sku
### Properties
* **name**: 'EP2_128_1T4_Mx1_W' | 'EP2_128_GPU1_Mx1_W' | 'EP2_256_2T4_W' | 'EP2_256_GPU2_Mx1' | 'EP2_64_1VPU_W' | 'EP2_64_Mx1_W' | 'Edge' | 'EdgeMR_Mini' | 'EdgeMR_TCP' | 'EdgePR_Base' | 'EdgePR_Base_UPS' | 'EdgeP_Base' | 'EdgeP_High' | 'GPU' | 'Gateway' | 'Management' | 'RCA_Large' | 'RCA_Small' | 'RDC' | 'TCA_Large' | 'TCA_Small' | 'TDC' | 'TEA_1Node' | 'TEA_1Node_Heater' | 'TEA_1Node_UPS' | 'TEA_1Node_UPS_Heater' | 'TEA_4Node_Heater' | 'TEA_4Node_UPS_Heater' | 'TMA' | string: SKU name.
* **tier**: 'Standard' | string: The SKU tier. This is based on the SKU name.

## StorageAccountCredentialProperties
### Properties
* **accountKey**: [AsymmetricEncryptedSecret](#asymmetricencryptedsecret): Encrypted storage key.
* **accountType**: 'BlobStorage' | 'GeneralPurposeStorage' | string (Required): Type of storage accessed on the storage account.
* **alias**: string (Required): Alias for the storage account.
* **blobDomainName**: string: Blob end point for private clouds.
* **connectionString**: string: Connection string for the storage account. Use this string if username and account key are not specified.
* **sslStatus**: 'Disabled' | 'Enabled' | string (Required): Signifies whether SSL needs to be enabled or not.
* **storageAccountId**: string: Id of the storage account.
* **userName**: string: Username for the storage account.

## StorageAccountProperties
### Properties
* **blobEndpoint**: string (ReadOnly): BlobEndpoint of Storage Account
* **containerCount**: int (ReadOnly): The Container Count. Present only for Storage Accounts with DataPolicy set to Cloud.
* **dataPolicy**: 'Cloud' | 'Local' | string (Required): Data policy of the storage Account.
* **description**: string: Description for the storage Account.
* **storageAccountCredentialId**: string: Storage Account Credential Id
* **storageAccountStatus**: 'NeedsAttention' | 'OK' | 'Offline' | 'Unknown' | 'Updating' | string: Current status of the storage account

## SubscriptionProperties
### Properties
* **locationPlacementId**: string
* **quotaId**: string
* **registeredFeatures**: [SubscriptionRegisteredFeatures](#subscriptionregisteredfeatures)[]
* **serializedDetails**: string
* **tenantId**: string

## SubscriptionRegisteredFeatures
### Properties
* **name**: string
* **state**: string

## SymmetricKey
### Properties
* **connectionString**: [AsymmetricEncryptedSecret](#asymmetricencryptedsecret): Connection string based on the symmetric key.

## SystemData
### Properties
* **createdAt**: string: The timestamp of resource creation (UTC).
* **createdBy**: string: The identity that created the resource.
* **createdByType**: 'Application' | 'Key' | 'ManagedIdentity' | 'User' | string: The type of identity that created the resource.
* **lastModifiedAt**: string: The timestamp of resource last modification (UTC)
* **lastModifiedBy**: string: The identity that last modified the resource.
* **lastModifiedByType**: 'Application' | 'Key' | 'ManagedIdentity' | 'User' | string: The type of identity that last modified the resource.

## TrackingInfo
### Properties
* **carrierName**: string: Name of the carrier used in the delivery.
* **serialNumber**: string: Serial number of the device being tracked.
* **trackingId**: string: Tracking ID of the shipment.
* **trackingUrl**: string: Tracking URL of the shipment.

## UpdateDetails
### Properties
* **estimatedInstallTimeInMins**: int: Estimated Install Time for the update
* **friendlyVersionNumber**: string: Friendly Version Number
* **installationImpact**: 'DeviceRebooted' | 'KubernetesWorkloadsDown' | 'None' | string: Impact of Installing an updateType
* **rebootBehavior**: 'NeverReboots' | 'RequestReboot' | 'RequiresReboot' | string: Indicates if updates are available and at least one of the updates needs a reboot.
* **status**: 'DownloadCompleted' | 'DownloadPending' | 'DownloadStarted' | 'InstallCompleted' | 'InstallStarted' | string: Status of the update.
* **targetVersion**: string: Target Version number
* **updateSize**: int: Size of the update(In Bytes)
* **updateTitle**: string: Title of the Update
* **updateType**: 'Firmware' | 'Kubernetes' | 'Software' | string: Type of the Update

## UpdateSummaryProperties
### Properties
* **deviceLastScannedDateTime**: string: The last time when a scan was done on the device.
* **deviceVersionNumber**: string: The current version of the device in format: 1.2.17312.13.",
* **friendlyDeviceVersionName**: string: The current version of the device in text format.
* **inProgressDownloadJobId**: string (ReadOnly): The job ID of the download job in progress.
* **inProgressDownloadJobStartedDateTime**: string (ReadOnly): The time when the currently running download (if any) started.
* **inProgressInstallJobId**: string (ReadOnly): The job ID of the install job in progress.
* **inProgressInstallJobStartedDateTime**: string (ReadOnly): The time when the currently running install (if any) started.
* **lastCompletedDownloadJobDateTime**: string (ReadOnly): The time when the last Download job was completed (success/cancelled/failed) on the appliance.
* **lastCompletedDownloadJobId**: string (ReadOnly): JobId of the last ran download job.(Can be success/cancelled/failed)
* **lastCompletedInstallJobDateTime**: string (ReadOnly): The time when the last Install job was completed (success/cancelled/failed) on the appliance.
* **lastCompletedInstallJobId**: string (ReadOnly): JobId of the last ran install job.(Can be success/cancelled/failed)
* **lastCompletedScanJobDateTime**: string: The time when the last scan job was completed (success/cancelled/failed) on the appliance.
* **lastDownloadJobStatus**: 'Canceled' | 'Failed' | 'Invalid' | 'Paused' | 'Running' | 'Scheduled' | 'Succeeded' | string (ReadOnly): JobStatus of the last ran download job.
* **lastInstallJobStatus**: 'Canceled' | 'Failed' | 'Invalid' | 'Paused' | 'Running' | 'Scheduled' | 'Succeeded' | string (ReadOnly): JobStatus of the last ran install job.
* **lastSuccessfulInstallJobDateTime**: string: The time when the Last Install job was completed successfully on the appliance
* **lastSuccessfulScanJobTime**: string: Time when the last scan job is successfully completed.
* **ongoingUpdateOperation**: 'Download' | 'Install' | 'None' | 'Scan' | string (ReadOnly): The current update operation.
* **rebootBehavior**: 'NeverReboots' | 'RequestReboot' | 'RequiresReboot' | string (ReadOnly): Indicates if updates are available and at least one of the updates needs a reboot.
* **totalNumberOfUpdatesAvailable**: int (ReadOnly): The number of updates available for the current device version as per the last device scan.
* **totalNumberOfUpdatesPendingDownload**: int (ReadOnly): The total number of items pending download.
* **totalNumberOfUpdatesPendingInstall**: int (ReadOnly): The total number of items pending install.
* **totalTimeInMinutes**: int (ReadOnly): The total time in Minutes
* **totalUpdateSizeInBytes**: int (ReadOnly): The total size of updates available for download in bytes.
* **updates**: [UpdateDetails](#updatedetails)[] (ReadOnly): The list of updates available for install.
* **updateTitles**: string[] (ReadOnly): The list of updates available for install.

## UserAccessRight
### Properties
* **accessType**: 'Change' | 'Custom' | 'Read' | string (Required): Type of access to be allowed for the user.
* **userId**: string (Required): User ID (already existing in the device).

## UserProperties
### Properties
* **encryptedPassword**: [AsymmetricEncryptedSecret](#asymmetricencryptedsecret): The password details.
* **shareAccessRights**: [ShareAccessRight](#shareaccessright)[] (ReadOnly): List of shares that the user has rights on. This field should not be specified during user creation.
* **userType**: 'ARM' | 'LocalManagement' | 'Share' | string (Required): Type of the user.

## VmMemory
### Properties
* **currentMemoryUsageMB**: int: The current memory used by the virtual machine.
* **startupMemoryMB**: int: The total amount of RAM in the virtual machine, as seen by the guest  operating system. For a virtual machine with dynamic memory enabled, this represents the initial memory available at startup.

