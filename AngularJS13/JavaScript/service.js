/// <reference path="app.js" />

app.factory("stringService", function() {
    return {
        processString: function (inputstr) {
            var output = "";
            if (inputstr != undefined) {

                for (var i = 0; i < inputstr.length; i++) {
                    if (i > 0 && inputstr[i].toUpperCase()) {
                        output = output + " ";
                    }
                    output = output + inputstr[i];
                }
            }
            return output;
        }

};

});
