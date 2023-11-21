﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesRentalClient.MovieService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieService.IMoviesService")]
    public interface IMoviesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllMovies", ReplyAction="http://tempuri.org/IMoviesService/GetAllMoviesResponse")]
        string GetAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetAllMovies", ReplyAction="http://tempuri.org/IMoviesService/GetAllMoviesResponse")]
        System.Threading.Tasks.Task<string> GetAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetMovie", ReplyAction="http://tempuri.org/IMoviesService/GetMovieResponse")]
        string GetMovie(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/GetMovie", ReplyAction="http://tempuri.org/IMoviesService/GetMovieResponse")]
        System.Threading.Tasks.Task<string> GetMovieAsync(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/RentedMovies", ReplyAction="http://tempuri.org/IMoviesService/RentedMoviesResponse")]
        string RentedMovies(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/RentedMovies", ReplyAction="http://tempuri.org/IMoviesService/RentedMoviesResponse")]
        System.Threading.Tasks.Task<string> RentedMoviesAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/AddMovie", ReplyAction="http://tempuri.org/IMoviesService/AddMovieResponse")]
        bool AddMovie(string name, string imagePath, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/AddMovie", ReplyAction="http://tempuri.org/IMoviesService/AddMovieResponse")]
        System.Threading.Tasks.Task<bool> AddMovieAsync(string name, string imagePath, string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/DeleteMove", ReplyAction="http://tempuri.org/IMoviesService/DeleteMoveResponse")]
        bool DeleteMove(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/DeleteMove", ReplyAction="http://tempuri.org/IMoviesService/DeleteMoveResponse")]
        System.Threading.Tasks.Task<bool> DeleteMoveAsync(int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/RentMovie", ReplyAction="http://tempuri.org/IMoviesService/RentMovieResponse")]
        bool RentMovie(int movieId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/RentMovie", ReplyAction="http://tempuri.org/IMoviesService/RentMovieResponse")]
        System.Threading.Tasks.Task<bool> RentMovieAsync(int movieId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/IsMovieAlreadyRented", ReplyAction="http://tempuri.org/IMoviesService/IsMovieAlreadyRentedResponse")]
        bool IsMovieAlreadyRented(int userId, int movieId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesService/IsMovieAlreadyRented", ReplyAction="http://tempuri.org/IMoviesService/IsMovieAlreadyRentedResponse")]
        System.Threading.Tasks.Task<bool> IsMovieAlreadyRentedAsync(int userId, int movieId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMoviesServiceChannel : MoviesRentalClient.MovieService.IMoviesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MoviesServiceClient : System.ServiceModel.ClientBase<MoviesRentalClient.MovieService.IMoviesService>, MoviesRentalClient.MovieService.IMoviesService {
        
        public MoviesServiceClient() {
        }
        
        public MoviesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAllMovies() {
            return base.Channel.GetAllMovies();
        }
        
        public System.Threading.Tasks.Task<string> GetAllMoviesAsync() {
            return base.Channel.GetAllMoviesAsync();
        }
        
        public string GetMovie(int movieId) {
            return base.Channel.GetMovie(movieId);
        }
        
        public System.Threading.Tasks.Task<string> GetMovieAsync(int movieId) {
            return base.Channel.GetMovieAsync(movieId);
        }
        
        public string RentedMovies(int userId) {
            return base.Channel.RentedMovies(userId);
        }
        
        public System.Threading.Tasks.Task<string> RentedMoviesAsync(int userId) {
            return base.Channel.RentedMoviesAsync(userId);
        }
        
        public bool AddMovie(string name, string imagePath, string description) {
            return base.Channel.AddMovie(name, imagePath, description);
        }
        
        public System.Threading.Tasks.Task<bool> AddMovieAsync(string name, string imagePath, string description) {
            return base.Channel.AddMovieAsync(name, imagePath, description);
        }
        
        public bool DeleteMove(int movieId) {
            return base.Channel.DeleteMove(movieId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteMoveAsync(int movieId) {
            return base.Channel.DeleteMoveAsync(movieId);
        }
        
        public bool RentMovie(int movieId, int userId) {
            return base.Channel.RentMovie(movieId, userId);
        }
        
        public System.Threading.Tasks.Task<bool> RentMovieAsync(int movieId, int userId) {
            return base.Channel.RentMovieAsync(movieId, userId);
        }
        
        public bool IsMovieAlreadyRented(int userId, int movieId) {
            return base.Channel.IsMovieAlreadyRented(userId, movieId);
        }
        
        public System.Threading.Tasks.Task<bool> IsMovieAlreadyRentedAsync(int userId, int movieId) {
            return base.Channel.IsMovieAlreadyRentedAsync(userId, movieId);
        }
    }
}