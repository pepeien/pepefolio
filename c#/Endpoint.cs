namespace pepefolio
{
    public struct RequestMethod {
        public const String Get = "GET";
        public const String Post = "POST";
        public const String Delete = "DELETE";
        public const String Put = "PUT";
        public const String Patch = "PATCH";
    }

    public struct RequestCredentials
    {
        public const String Include = "include";
        public const String SameOrigin = "same-origin";
        public const String Omit = "omit";
    }

    public class EndpointParameters
    {
        public List<Parameter> Search { get; set; }
        public List<Parameter> Query { get; set; }
        public List<Parameter> Body { get; set; }
    }

    public class VariantEndpoint
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public String Method { get; set; }
        public EndpointParameters Parameters { get; set; }
        public RequestCredentials Credentials { get; set; }
    }

    public class Endpoint
    {
        public String Name { get; set; }
        public String Path { get; set; }
        public int Version { get; set; }
        public RequestMethod Method { get; set; }
        public List<VariantEndpoint> Variants { get; set; }
        public EndpointParameters Parameters { get; set; }
        public RequestCredentials Credentials { get; set; }
    }

}