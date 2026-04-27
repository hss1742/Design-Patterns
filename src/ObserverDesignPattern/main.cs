using src.ObserverDesignPattern.Models;
using src.ObserverDesignPattern.Notification;
using src.ObserverDesignPattern.Observable;
using src.ObserverDesignPattern.Observer;


var product = new Product("IPhone", 0);
var user = new User("Harjeet", "xyz@com", 16042002);
var user2 = new User("Jon", "abc@com", 05011970);

var iphoneObservable = new Observable(product);
var emailobserver = new Observer(iphoneObservable, new EmailNotification(), user);
var textobserver = new Observer(iphoneObservable, new TextNotification(), user2);
iphoneObservable.AddObserver(emailobserver);
iphoneObservable.AddObserver(textobserver);
iphoneObservable.SetQuantity(10);
