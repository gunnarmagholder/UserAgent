(function() {
	var app = angular.module('test', []);
	app.controller('TestController', ['$http', function ($http) {
		var test = this;
        test.data=['groupA','groupB','groupC'];
		test.users = [];
		$http.get("data.json").success(function(data){
			test.users = data;
		});
        
        test.members = [];
		// $http.get("groupA.json").success(function(data){
			// test.members= data;
		// });
        
        var groupsMembers=[];
        var userMembers=[];
        
        test.selectGroup=function(group){
            $http.get(group+".json").success(function(data){
			test.members= data;
                groupsMembers=data;
             });

             $http.get("data.json").success(function(data){
			 test.users = data;
                userMembers=data;
		     });
             
             test.users = userMembers.filter(function(item) {
                  return !groupsMembers.some(function(test){
                    return test.SAMAccountName === item.SAMAccountName;
                });
             });

            // test.users=diff;
            console.log("ult");
            for(var i=0; i<test.users.length;i++){
                console.log(test.users[i].SAMAccountName);
            }
            
        };
    }])
         
})();