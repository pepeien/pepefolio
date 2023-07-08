export type RequestMethod = "GET" | "POST" | "DELETE" | "PUT" | "PATCH";

export interface Parameter {
    label: string;
    defaultValue: string;
    type: string;
}

export interface EndpointParameters {
    search?: Parameter[];
    query?: Parameter[];
    body?: Parameter[];
}

export interface Endpoint {
    name: string;
    path: string;
    version: number;
    method: RequestMethod;
    variants?: VariantEndpoint[];
    parameters?: EndpointParameters;
    credentials?: RequestCredentials;
}

export type VariantEndpoint = Omit<Endpoint, "version" | "variants">;
