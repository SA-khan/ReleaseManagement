public class ENVIRONMENT
{
    public virtual int ENV_ID { get; set; }
    public virtual CLIENT ENV_CLI_ID { get; set; }
    public virtual PRODUCT ENV_PROD_ID { get; set; }
    public virtual ENVIRONMENT_TYPE ENV_TYPE { get; set; }
    public virtual string ENV_NAME { get; set; }
    public virtual string ENV_TITLE { get; set; }
    public virtual string ENV_SERVER_NAME { get; set; }
    public virtual string ENV_SERVER_REGISTER_TYPE { get; set; }
    public virtual string ENV_SERVER_VIRTUALIZATION { get; set; }
    public virtual int ENV_SERVER_MEMORY { get; set; }
    public virtual string ENV_SERVER_PROCESSOR { get; set; }
    public virtual string ENV_SERVER_HARDWARE_DETAIL { get; set; }
    public virtual string ENV_SERVER_OPERATING_SYSTEM { get; set; }
    public virtual string ENV_SERVER_OPERATING_SYSTEM_VERSION { get; set; }
    public virtual string ENV_SERVER_OPERATING_SYSTEM_DETAIL { get; set; }
    public virtual string ENV_RUNNING_APP_TYPE { get; set; }
    public virtual string ENV_WEB_SERVER_NAME { get; set; }
    public virtual string ENV_WEB_SERVER_VERSION { get; set; }
    public virtual string ENV_WEB_SERVER_DETAIL { get; set; }
    public virtual string ENV_APP_FRAMEWORK { get; set; }
    public virtual string ENV_APP_RUNNING_IDENTITY { get; set; }
    public virtual string ENV_APP_RUNNING_HYPER_LINK { get; set; }
    public virtual string ENV_DOCKER_REGISTRY_IMAGE_SRC { get; set; }
    public virtual string ENV_DOCKER_CONTAINER_TYPE { get; set; }
    public virtual string ENV_APP_WORKING_DIRECTORY_LOCATION { get; set; }
    public virtual string ENV_SERVER_IP_ADDRESS { get; set; }
    public virtual string ENV_SERVER_RUNNING_PORT { get; set; }
    public virtual string ENV_OVERVIEW { get; set; }
    public virtual string ENV_SERVER_COMMENTS { get; set; }

}
