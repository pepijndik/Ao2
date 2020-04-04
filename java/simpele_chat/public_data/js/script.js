"use strict";

const app = angular.module("app", []);

/* 
    Making factory method for socket 
*/
app.factory("socket", function ($rootScope) {
  const socket = io.connect();
  return {
    //Listen for the  event:
    on: function (eventName, callback) {
      socket.on(eventName, function () {
        var args = arguments;
        $rootScope.$apply(function () {
          callback.apply(socket, args);
        });
      });
    },
    //Post to event
    emit: function (eventName, data, callback) {
      socket.emit(eventName, data, function () {
        var args = arguments;
        $rootScope.$apply(function () {
          if (callback) {
            callback.apply(socket, args);
          }
        });
      });
    },
  };
});

app.controller("app", ($scope, socket) => {
  $scope.socketId = null;
  $scope.selectedUser = null;
  $scope.messages = [];
  $scope.msgData = null;
  $scope.userList = [];

  //Promt melding vragen om naam
  $scope.username = window.prompt("Enter Your Name");
  if ($scope.username === "") {
    window.location.reload();
  }

  //check of  gebruiker niet naar zichzelf bericht
  $scope.seletedUser = (selectedUser) => {
    selectedUser === $scope.socketId
      ? alert("Can't message to yourself.")
      : ($scope.selectedUser = selectedUser);
  };

  //Stuur bericht
  $scope.sendMsg = ($event) => {
    const keyCode = $event.which || $event.keyCode;

    if (keyCode === 13 && $scope.message !== null) {
      socket.emit("getMsg", {
        toid: $scope.selectedUser,
        msg: $scope.message,
        name: $scope.username,
      });
      $scope.message = null;
    }
  };

  socket.emit("username", $scope.username);

  //Verkijg gebruiker lijst socket
  socket.on("userList", (userList, socketId) => {
    if ($scope.socketId === null) {
      $scope.socketId = socketId;
    }
    $scope.userList = userList;
  });

  //Exist via socket
  socket.on("exit", (userList) => {
    $scope.userList = userList;
  });

  //verstuur bericht via socket
  socket.on("sendMsg", (data) => {
    $scope.messages.push(data);
  });
});
