/**
 * This interface defines a contract for a Service class.
 */
export interface IServer {
    callApi(): Promise<string>;
}