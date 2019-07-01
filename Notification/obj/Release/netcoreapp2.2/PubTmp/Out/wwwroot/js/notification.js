"use strict";
var connection = new signalR.HubConnectionBuilder().withUrl("/notification").build();
connection.on