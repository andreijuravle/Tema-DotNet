﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetCinemas", ReplyAction="http://tempuri.org/IMyService/GetCinemasResponse")]
        DotNet.Cinema[] GetCinemas();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetCinemas", ReplyAction="http://tempuri.org/IMyService/GetCinemasResponse")]
        System.Threading.Tasks.Task<DotNet.Cinema[]> GetCinemasAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMovies", ReplyAction="http://tempuri.org/IMyService/GetMoviesResponse")]
        DotNet.Movie[] GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetMovies", ReplyAction="http://tempuri.org/IMyService/GetMoviesResponse")]
        System.Threading.Tasks.Task<DotNet.Movie[]> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetActors", ReplyAction="http://tempuri.org/IMyService/GetActorsResponse")]
        DotNet.Actor[] GetActors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetActors", ReplyAction="http://tempuri.org/IMyService/GetActorsResponse")]
        System.Threading.Tasks.Task<DotNet.Actor[]> GetActorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTickets", ReplyAction="http://tempuri.org/IMyService/GetTicketsResponse")]
        DotNet.Ticket[] GetTickets();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/GetTickets", ReplyAction="http://tempuri.org/IMyService/GetTicketsResponse")]
        System.Threading.Tasks.Task<DotNet.Ticket[]> GetTicketsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCinema", ReplyAction="http://tempuri.org/IMyService/AddCinemaResponse")]
        DotNet.Cinema AddCinema(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddCinema", ReplyAction="http://tempuri.org/IMyService/AddCinemaResponse")]
        System.Threading.Tasks.Task<DotNet.Cinema> AddCinemaAsync(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddMovie", ReplyAction="http://tempuri.org/IMyService/AddMovieResponse")]
        DotNet.Movie AddMovie(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddMovie", ReplyAction="http://tempuri.org/IMyService/AddMovieResponse")]
        System.Threading.Tasks.Task<DotNet.Movie> AddMovieAsync(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddActor", ReplyAction="http://tempuri.org/IMyService/AddActorResponse")]
        DotNet.Actor AddActor(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddActor", ReplyAction="http://tempuri.org/IMyService/AddActorResponse")]
        System.Threading.Tasks.Task<DotNet.Actor> AddActorAsync(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddTicket", ReplyAction="http://tempuri.org/IMyService/AddTicketResponse")]
        DotNet.Ticket AddTicket(DotNet.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/AddTicket", ReplyAction="http://tempuri.org/IMyService/AddTicketResponse")]
        System.Threading.Tasks.Task<DotNet.Ticket> AddTicketAsync(DotNet.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCinema", ReplyAction="http://tempuri.org/IMyService/DeleteCinemaResponse")]
        void DeleteCinema(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteCinema", ReplyAction="http://tempuri.org/IMyService/DeleteCinemaResponse")]
        System.Threading.Tasks.Task DeleteCinemaAsync(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteMovie", ReplyAction="http://tempuri.org/IMyService/DeleteMovieResponse")]
        void DeleteMovie(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteMovie", ReplyAction="http://tempuri.org/IMyService/DeleteMovieResponse")]
        System.Threading.Tasks.Task DeleteMovieAsync(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteActor", ReplyAction="http://tempuri.org/IMyService/DeleteActorResponse")]
        void DeleteActor(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteActor", ReplyAction="http://tempuri.org/IMyService/DeleteActorResponse")]
        System.Threading.Tasks.Task DeleteActorAsync(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteTicket", ReplyAction="http://tempuri.org/IMyService/DeleteTicketResponse")]
        void DeleteTicket(DotNet.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/DeleteTicket", ReplyAction="http://tempuri.org/IMyService/DeleteTicketResponse")]
        System.Threading.Tasks.Task DeleteTicketAsync(DotNet.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateCinema", ReplyAction="http://tempuri.org/IMyService/UpdateCinemaResponse")]
        DotNet.Cinema UpdateCinema(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateCinema", ReplyAction="http://tempuri.org/IMyService/UpdateCinemaResponse")]
        System.Threading.Tasks.Task<DotNet.Cinema> UpdateCinemaAsync(DotNet.Cinema cinema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateMovie", ReplyAction="http://tempuri.org/IMyService/UpdateMovieResponse")]
        DotNet.Movie UpdateMovie(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateMovie", ReplyAction="http://tempuri.org/IMyService/UpdateMovieResponse")]
        System.Threading.Tasks.Task<DotNet.Movie> UpdateMovieAsync(DotNet.Movie movie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateActor", ReplyAction="http://tempuri.org/IMyService/UpdateActorResponse")]
        DotNet.Actor UpdateActor(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateActor", ReplyAction="http://tempuri.org/IMyService/UpdateActorResponse")]
        System.Threading.Tasks.Task<DotNet.Actor> UpdateActorAsync(DotNet.Actor actor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateTicket", ReplyAction="http://tempuri.org/IMyService/UpdateTicketResponse")]
        DotNet.Ticket UpdateTicket(DotNet.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/UpdateTicket", ReplyAction="http://tempuri.org/IMyService/UpdateTicketResponse")]
        System.Threading.Tasks.Task<DotNet.Ticket> UpdateTicketAsync(DotNet.Ticket ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : ConsoleApplication.ServiceReference.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<ConsoleApplication.ServiceReference.IMyService>, ConsoleApplication.ServiceReference.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DotNet.Cinema[] GetCinemas() {
            return base.Channel.GetCinemas();
        }
        
        public System.Threading.Tasks.Task<DotNet.Cinema[]> GetCinemasAsync() {
            return base.Channel.GetCinemasAsync();
        }
        
        public DotNet.Movie[] GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<DotNet.Movie[]> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public DotNet.Actor[] GetActors() {
            return base.Channel.GetActors();
        }
        
        public System.Threading.Tasks.Task<DotNet.Actor[]> GetActorsAsync() {
            return base.Channel.GetActorsAsync();
        }
        
        public DotNet.Ticket[] GetTickets() {
            return base.Channel.GetTickets();
        }
        
        public System.Threading.Tasks.Task<DotNet.Ticket[]> GetTicketsAsync() {
            return base.Channel.GetTicketsAsync();
        }
        
        public DotNet.Cinema AddCinema(DotNet.Cinema cinema) {
            return base.Channel.AddCinema(cinema);
        }
        
        public System.Threading.Tasks.Task<DotNet.Cinema> AddCinemaAsync(DotNet.Cinema cinema) {
            return base.Channel.AddCinemaAsync(cinema);
        }
        
        public DotNet.Movie AddMovie(DotNet.Movie movie) {
            return base.Channel.AddMovie(movie);
        }
        
        public System.Threading.Tasks.Task<DotNet.Movie> AddMovieAsync(DotNet.Movie movie) {
            return base.Channel.AddMovieAsync(movie);
        }
        
        public DotNet.Actor AddActor(DotNet.Actor actor) {
            return base.Channel.AddActor(actor);
        }
        
        public System.Threading.Tasks.Task<DotNet.Actor> AddActorAsync(DotNet.Actor actor) {
            return base.Channel.AddActorAsync(actor);
        }
        
        public DotNet.Ticket AddTicket(DotNet.Ticket ticket) {
            return base.Channel.AddTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<DotNet.Ticket> AddTicketAsync(DotNet.Ticket ticket) {
            return base.Channel.AddTicketAsync(ticket);
        }
        
        public void DeleteCinema(DotNet.Cinema cinema) {
            base.Channel.DeleteCinema(cinema);
        }
        
        public System.Threading.Tasks.Task DeleteCinemaAsync(DotNet.Cinema cinema) {
            return base.Channel.DeleteCinemaAsync(cinema);
        }
        
        public void DeleteMovie(DotNet.Movie movie) {
            base.Channel.DeleteMovie(movie);
        }
        
        public System.Threading.Tasks.Task DeleteMovieAsync(DotNet.Movie movie) {
            return base.Channel.DeleteMovieAsync(movie);
        }
        
        public void DeleteActor(DotNet.Actor actor) {
            base.Channel.DeleteActor(actor);
        }
        
        public System.Threading.Tasks.Task DeleteActorAsync(DotNet.Actor actor) {
            return base.Channel.DeleteActorAsync(actor);
        }
        
        public void DeleteTicket(DotNet.Ticket ticket) {
            base.Channel.DeleteTicket(ticket);
        }
        
        public System.Threading.Tasks.Task DeleteTicketAsync(DotNet.Ticket ticket) {
            return base.Channel.DeleteTicketAsync(ticket);
        }
        
        public DotNet.Cinema UpdateCinema(DotNet.Cinema cinema) {
            return base.Channel.UpdateCinema(cinema);
        }
        
        public System.Threading.Tasks.Task<DotNet.Cinema> UpdateCinemaAsync(DotNet.Cinema cinema) {
            return base.Channel.UpdateCinemaAsync(cinema);
        }
        
        public DotNet.Movie UpdateMovie(DotNet.Movie movie) {
            return base.Channel.UpdateMovie(movie);
        }
        
        public System.Threading.Tasks.Task<DotNet.Movie> UpdateMovieAsync(DotNet.Movie movie) {
            return base.Channel.UpdateMovieAsync(movie);
        }
        
        public DotNet.Actor UpdateActor(DotNet.Actor actor) {
            return base.Channel.UpdateActor(actor);
        }
        
        public System.Threading.Tasks.Task<DotNet.Actor> UpdateActorAsync(DotNet.Actor actor) {
            return base.Channel.UpdateActorAsync(actor);
        }
        
        public DotNet.Ticket UpdateTicket(DotNet.Ticket ticket) {
            return base.Channel.UpdateTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<DotNet.Ticket> UpdateTicketAsync(DotNet.Ticket ticket) {
            return base.Channel.UpdateTicketAsync(ticket);
        }
    }
}
