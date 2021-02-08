 



//var connection = new signalR.HubConnectionBuilder()
//    .withUrl("/chatt", {
//        accessTokenFactory: () => "testing"
//    })
//    .build();

//connection.on("PrimljenaPoruka", function (poruka) {

//    console.log("primljenaPoruka");
   

//    var datumVrijeme = new Date();
//    var dd = String(datumVrijeme.getDate()).padStart(2, '0');
//    var mm = String(datumVrijeme.getMonth() + 1).padStart(2, '0'); //January is 0!
//    var yyyy = datumVrijeme.getFullYear();

//    var h = datumVrijeme.getHours();
//    var min = datumVrijeme.getMinutes();

//    var datum = mm + '/' + dd + '/' + yyyy;
//    var vrijeme = h + ':' + min;

//    var temp = document.getElementById("chat_template");
//    var vrijemeUl = temp.content.getElementById("chat_time").getElementsByTagName("UL")[0];
//    vrijemeUl.getElementsByTagName("LI")[0].innerHTML = datum;
//    vrijemeUl.getElementsByTagName("LI")[1].innerHTML = vrijeme;

   

//    var porukaUl = temp.content.getElementById("poruka_value").getElementsByTagName("UL")[0];
//    porukaUl.getElementsByTagName("LI")[0].innerHTML = "user";
//    porukaUl.getElementsByTagName("LI")[1].innerHTML = poruka;
//    var clon = temp.content.cloneNode(true);
//    document.getElementById("chatbox_body").appendChild(clon);

  
    
   
//});

//$(function () {

//    connection.invoke('getConnectionId')
//    .then(function (connectionId) {
//        console.log(connectionId);
//    });




//})
//connection.invoke('getConnectionId')
//    .then(function (connectionId) {
//        // Send the connectionId to controller
//    });
//connection.start().done(function () {
//    console.log("id : %o", $.connection.hub.id);
//});



//connection.start().then(function () {
//    connection.invoke('GetConnectionId')
//    .then(function (connectionId) {
//       alert(connectionId);
//   })

//}).catch(err => console.error(err));



//connection.start().then(function () {
//    connection.invoke('GetConnectionID')
//        .then(function (connectionId))
//    {
//        console.log("aaaa")
//    }
//}).catch(err => console.error(err));




//connection.start().catch(function (err) {
//    return console.error(err.toString());
//});



//connection.start().done(function () {
//    // Wire up Send button to call NewContosoChatMessage on the server.
//    console.log("id : %o" + $.connection.hub.id);
//});

//document.getElementById("sid").addEventListener("click", function (event) {
//    //var message = document.getElementById("btn-input").value;



//    connection.invoke("SendMessageToAll", message).catch(function (err) {
//        return console.error(err.toString());
//    });


//    event.preventDefault();
//});
