
(function($) {
  'use strict';

    var tableFour = $('#account-lists').DataTable({
        pageLength:10,
        ajax: {
            url: '/Account/GetAccountList',
            dataSrc:'' ,
        },

        //columns: [
        //    { title: "Account Name", data:"fullName" },
        //    { title: "Start Date Profile", data:"startDateProfile"},

        //    { title: "Phone Number", data:"phoneNumber" },
        //    { title: "Email Address", data:"email" }
        //],
        
  });
})(jQuery);
