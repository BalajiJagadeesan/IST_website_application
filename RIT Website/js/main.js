/**
 * Created by Balaji Jagadeesan on 11/05/2016.
 */

/**
 * The following set of functions are invoked when the document is ready
 */
$(document).ready(function (){
    /**
     * The jQuery function to configure the outdatedbrowser plugin
     */
    outdatedBrowser({
        bgColor: '#f25648',
        color: '#ffffff',
        lowerThan: 'transform',
        languagePath: ''
    });

    /**
     * The jQuery function to render navbar as responsive side menu
     */
    $('#responsive-menu-button').sidr({
        source: '#navigation',
        displace:false
    });

    /**
     * AJAX Call to fetch the welcome content of the page
     */
    myXhr("get", {path: "/about/"}, "#about").done(function (json) {
        var x = "<div id='aboutcontent'><h2>" + json.title + "</h2>";
        x += "<p>" + json.description + "</p><br>";
        x += "<p>" + json.quote + "</p>";
        x += "<p><i>-" + json.quoteAuthor + "</i></p></div>";

        /**
         * To put retrieved content onto the about section of the page
         */
        $("#about").html(x);
    });

    /**
     * AJAX Call to get data about undergraduate degree provided by RIT
     */
    myXhr("get", {path: "/degrees/undergraduate/"}, "#undergraduate").done(function (json) {
        var x="<h2 class='titleCourse'>Our Undergraduate Programs</h2><br/>";
        x+="<div class='containerCard'>";
        $.each(json.undergraduate, function (i, item) {

            /**
             * Creation of card for UG degree with onclick function
             */
            x += "<div class='card' onclick='getDegreeUG(this)' data-class='card' data-degree='" + item.degreeName + "'>";
            x += "<h2>" +item.title + "</h2>" + "<p>" + item.description + "</p><i class='fa fa-plus-circle fa-lg' aria-hidden='true'></i>" +
                "</div>";
        });
        x+="</div>";

        /**
         * To put retrieved content onto the undergraduate section of the page
         */
        $("#undergraduate").append(x);

        randomizer();
    });

    /**
     * AJAX Call to get data about graduate degree provided by RIT
     */
    myXhr("get",{path:"/degrees/graduate/"},"#graduate").done(function (json) {
        var y="";
        var x="<div><h2 class='titleCourse'>Our Graduate Programs</h2><div class='containerCardG'>";
        $.each(json.graduate ,function(i,item){

            /**
             * If object contains title,then it is graduate degree
             */
            if(item.title) {

                /**
                 * Creation of card for Graduate degree with onclick function
                 */
                x += "<div class='cardG' onclick='getGraduate(this)' data-degree='"+item.degreeName+"'>";
                x += "<h2>" +item.title + "</h2>" + "<p>" + item.description + "</p>" +
                    "<i class='fa fa-plus-circle fa-lg' aria-hidden='true'></i>" +
                    "</div>";
            }
            else{

                /**
                 *Else it is Advanced Certificates ,print cert object
                 */
                y += "<div class='cert'>" +
                    "<h2>Our Graduate Advanced Certificates</h2>";
                $.each(item.availableCertificates,function(j,cert){
                    y+="<p>"+cert+"</p>"
                });
                y+="</div>";
            }
        });
        x+="</div>";

        /**
         *Append Graduate degree and then advanced certificates
         */
        x += y;
        x+="</div>";

        /**
         * To put retrieved content onto the graduate section of the page
         */
        $("#graduate").append(x);
    });

    /**
     * AJAX Call to get graduate minors provided by the RIT
     */
    myXhr("get",{path:"/minors/"},"#minors").done(function (json){
        var x="<h2 class='titleCourse'>Our UnderGraduate Minor Programs</h2><div class='containerCardMinor'>";
        console.log(json);
        $.each(json.UgMinors ,function(i,item){

            /**
             * Creation of card for minors  with onclick function
             */
            x+="<div class='cardMinors' data-class='card' onclick='getMinors(this)' data-minors='"+item.name+"'>";
            x+="<h4>"+ item.title+"</h4>";
            x+="<i class='fa fa-plus-circle fa-lg' aria-hidden='true'></i></div>";
        });
        x+="</div>";
        /**
         * To put retrieved content onto the minors section of the page
         */
        $("#minors").append(x);
        randomizer();
    });

    /**
     * AJAX call to get employment details
     */
    myXhr("get",{path:"/employment/"},"#employment").done(function (json){
        var x="";
        x+="<div class='emp'><h2 class='titleCourse'>"+json.introduction.title+"</h2>";
        x+="<h4 class='titleCourse'>"+json.introduction.content[0].title+"</h4>";
        x+="<p>"+json.introduction.content[0].description+"</p><br><br>" +
            "<div class='containerCardStatistics'>";
        $.each(json.degreeStatistics.statistics,function (i,item) {

            /**
             * Creation of card for Statistics
             */
            x+="<div class='cardStatistics' data-class='card'><h3>"+ item.value +"</h3>" +
                "<h5>"+ item.description +"</h5></div>"
        });
        x+="<br></div></div>";

        x+="<div class='emp'><h2 class='titleCourse'>"+json.introduction.title+"</h2>";
        x+="<h4>"+json.introduction.content[1].title+"</h4>";
        x+="<p>"+json.introduction.content[1].description+"</p>";

        x+="<h4>"+json.employers.title+"</h4><div class='listEmp'>";
        $.each(json.employers.employerNames,function (i,item) {
            x+="<h5 class='listEmp'>"+item+"</h5>"
        });
        x+="</div></div>";

        x+="<div class='emp'><h4>"+json.careers.title+"</h4><div class='listEmp'>";
        $.each(json.careers.careerNames,function (i,item) {
            x+="<h5 class='listEmp'>"+item+"</h5>"
        });
        x+="</div></div>";

        /**
         * To put retrieved content onto the employment section of the page
         */
        $("#employment").append(x);

        randomizer();
    });

    /**
     * function call to generate map and table card onto the mapdata section
     */
    genMapContent();

    /**
     * AJAX call to get faculty and staff details
     */
    myXhr("get", {path: "/people/"}, "#people").done(function (json) {

        /**
         * Basic tabbed view with two options faculty and staff
         * On click Toggle between tabs
         */
        var x = "<div class='container 'style='text-align: center'>" +
            "<ul class='tabs'>" +
            "<li class='tab-link current' data-tab='tab-1' onclick='changeTabs(this)'>Faculty</li>"+
            "<li class='tab-link' data-tab='tab-2' onclick='changeTabs(this)'>Staff</li></ul>"+
            "<div  id='tab-1' class='tab-content current'>" +
            "<h2 style='color: white;'>Our faculty</h2>" +
            "<div id='pic' class='diamondswrap'>";

        /**
         * faculty div
         */
        $.each(json.faculty, function (i, item) {
            var name=item.name+','+item.title;
            x += "<img id='picitem' class='item' title='"+name+"' onclick='getFac(this)' src='"+item.imagePath+"' data-image='"+item.imagePath+"' data-username='" + item.username + "'/>";
        });
        x+="</div></div>";
        x+="<div id='tab-2' class='tab-content'>" +
            "<h2 style='color: white;'>Our staff</h2>" +
            "<div id='pic2' class='diamondswrap'>";

        /**
         * Staff div
         */
        $.each(json.staff, function (i, item) {
            var name=item.name+','+item.title;
            x += "<img id='picitem2' class='item' title='"+name+"' onclick='getStaff(this)' src='"+item.imagePath+"' data-image='"+item.imagePath+"' data-username='" + item.username + "'/>";
        });

        x+="</div></div></div>";

        /**
         * To put retrieved content onto the people section of the page
         */
        $("#people").html(x);

        /**
         * Initialize separate diamond renderer for faculty and staff
         */
        $("#pic").diamonds({
            size : 175,
            gap : 5,
            hideIncompleteRow : false, // default: false
            autoRedraw :true , // default: true
            itemSelector : ".item"
        });

        $("#pic2").diamonds({
            size : 175,
            gap : 5,
            hideIncompleteRow : false, // default: false
            autoRedraw :true , // default: true
            itemSelector : ".item"
        });
    });

    /**
     * Function call to assign color to the cards
     */
    randomizer();

    /**
     * Initializer function for parallax rendering
     */
    $.stellar({
        horizontalScrolling: false,
        responsive: true
    });

});

/**
 * Invoked when clicked,used to switch between faculty and staff
 * @param dom entire called object is passed to the function
 */
function changeTabs(dom){
    var tab_id = $(dom).attr('data-tab');

    $('ul.tabs li').removeClass('current');
    $('.tab-content').removeClass('current');

    $(dom).addClass('current');
    $("#"+tab_id).addClass('current');
}

/**
 * function definition to generate map and table cards using api access
 */
function genMapContent(){
    var x="<div style='text-align: center'><h2>Where our Students Work</h2><h4>Click on pins to get more details</h4>" +
        "<div class='mapdata'>"+
        "<iframe class='framemap' src='https://ist.rit.edu/api/map/' width='100%' height='500px' frameborder='0' scrolling='no'></iframe>" +
        "</div><h2>Some employment and co-op history  </h2><div class='containerTableCard'>"+
        "<div class='tablecard' data-class='card' onclick='tablecoop(this)'>CO-OP Table</div>"+
        "<div class='tablecard' data-class='card' onclick='tableemp(this)'>Employment Table</div>" +
        "</div></div>";
    $(x).appendTo("#mapdata");
}

/**
 * The function to display details of the selected undergraduate program
 * @param dom entire called object is passed to the function
 */
function getDegreeUG(dom) {
    myXhr("get", {path: "/degrees/undergraduate/degreeName=" + $(dom).attr('data-degree')}, null).done(function (json) {
        var x="<div class='titleCourse'><h3>"+json.title+"</h3>";
        x+="<p>"+json.description+"</p><h5>Courses Offered</h5>";
        $.each(json.concentrations,function (item,i) {
            x+="<div class='courseBox'>"+json.concentrations[item]+"</div>"
        });
        x+="</div>";

        /**
         * Modal is created using content fetched using AJAX call
         */
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            closeButton:'box',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });
    });
}

/**
 * The function to display details of the selected graduate program
 * @param dom entire called object is passed to the function
 */
function getGraduate(dom){
    myXhr("get",{path:"/degrees/graduate/degreeName"+$(dom).attr('data-degree')},null).done(function(json){
        var x="<div class='titleCourse'><h3>"+json[0].title+"</h3>";
        x+="<p>"+json[0].description+"</p><h5>Courses Offered</h5>";
        $.each(json[0].concentrations,function (j,cert) {
            x+="<div class='courseBox'>"+cert+"</div>"
        });
        x+="</div>";

        /**
         * Modal is created using content fetched using AJAX call
         *
         */
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip', //To animate on open
            closeButton:'box', //To put close button onto the jbox else it will be in overlay
            onCloseComplete:function () {
                //destroy on close
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });
    });
}

/**
 * Function to get details about the selected minors
 * @param dom entire called object is passed to the function
 */
function getMinors(dom) {
    var x="";
    var minor=$(dom).attr('data-minors');
    myXhr("get",{path:"/minors/"},"#minors").done(function (json){
        $.each(json.UgMinors ,function(i,item){
           // console.log(item.name);
            if(minor==item.name){
                x="<div class='titleCourse'><h3>"+item.title+"</h3>";
                x+="<p>"+item.description+"</p><h5>Courses Offered</h5><div class='containerCardMinor'></div>";
                $.each(item.courses,function (j,course) {

                    /**
                     * Creation of card for course names with onclick function
                     */
                    x+="<div class='cardMinors' style='color: #0c0c0c' onclick='getCourseDetails(this)' data-courseid='"+ course +"'>"+ course
                        +"</div>"
                });
                x+="</div><p>"+item.note+"</p>";
                x+="</div>";
           }
        });
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            closeButton:'box',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });
    });
}

/**
 * Function to get details about the selected course
 * @param dom entire called object is passed to the function
 */
function getCourseDetails(dom){
    var x="";
    myXhr("get",{path:"/course/courseID="+$(dom).attr('data-courseid')},null).done(function(json){
        console.log(json);
        x="<div class='titleCourse'><h3>"+json.title+"</h3>";
        x+="<p>"+json.description+"</p>";
        x+="</div>";

        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            closeButton:'box',
            onCloseComplete:function () {
                this.destroy();
            }
        });
    });
}

/**
 * Function to generate CO-OP Table and design it with dataTables plugin
 * @param dom entire called object is passed to the function
 */
function tablecoop(dom){
    myXhr("get",{path:"/employment/coopTable/coopInformation/"},null).done(function(json){
        var x="<div class='tableContent'><table id='tableContent'>";
        x+="<thead><tr><th>Employer</th>";
        x+="<th>City</th>";
        x+="<th>Degree</th>";
        x+="<th>Term</th></tr></thead>";
        $.each(json.coopInformation ,function(i,item){
            x+="<tr>";
            x+="<td>"+item.employer+"</td>";
            x+="<td>"+item.city+"</td>";
            x+="<td>"+item.degree+"</td>";
            x+="<td>"+item.term+"</td>";
            x+="</tr>";
        });
        x+="</table></div>";

        /**
         * put table in jBox
         */
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });

        /**
         * Render table after creation of jBox
         */
        $(document).find('#tableContent').DataTable();
    });
}

/**
 * Function to generate Employment Table and design it with dataTables plugin
 * @param dom entire called object is passed to the function
 */
function tableemp(dom){
    myXhr("get",{path:"/employment/employmentTable/professionalEmploymentInformation/"},null).done(function(json){
        var x="<div class='tableContent'><table id='tableContent'>";
        x+="<thead><tr><th>Employer</th>";
        x+="<th>City</th>";
        x+="<th>Degree</th>";
        x+="<th>Title</th>";
        x+="<th>Start-Date</th></tr></thead>";
        $.each(json.professionalEmploymentInformation ,function(i,item){
            x+="<tr>";
            x+="<td>"+item.employer+"</td>";
            x+="<td>"+item.city+"</td>";
            x+="<td>"+item.degree+"</td>";
            x+="<td>"+item.title+"</td>";
            x+="<td>"+item.startDate+"</td>";
            x+="</tr>";
        });
        x+="</table></div>";

        /**
         * Put table in jBox and create it
         */
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });

        /**
         * To render table after creating jBox
         */
        $(document).find('#tableContent').DataTable();
    });
}

/**
 * The faculty info is generated on demand
 * @param dom entire called object is passed to the function
 */
function getFac(dom) {
    myXhr("get", {path: "/people/faculty/username=" + $(dom).attr('data-username')}, null).done(function (json) {
        console.log(json);
        var x="<div>";
        x+="<h2>"+json.name+"</h2><h4>"+json.title+"</h4>";
        x+="<img src='"+json.imagePath+"'/>";
        x+="<p>Area of Interest:"+json.interestArea+"</p>";
        x+="<p>Phone:"+json.phone+"</p>";
        x+="<p>Office:"+json.office+"</p>";
        x+="<p>E-mail:"+json.email+"</p>";
        x+="</div>";
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            closeButton:'box',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });

    });
}

/**
 * The staff info is generated on demand
 * @param dom entire called object is passed to the function
 */
function getStaff(dom){
    myXhr("get", {path: "/people/staff/username=" + $(dom).attr('data-username')}, null).done(function (json) {
        console.log(json);
        var x="<div>";
        x+="<h2>"+json.name+"</h2><h4>"+json.title+"</h4>";
        x+="<img src='"+json.imagePath+"'/>";
        x+="<p>Phone:"+json.phone+"</p>";
        x+="<p>Office:"+json.office+"</p>";
        x+="<p>E-mail:"+json.email+"</p>";
        x+="</div>";
        $(dom).jBox("Modal",{
            content:x,
            animation:'flip',
            closeButton:'box',
            onCloseComplete:function () {
                this.destroy();
                $('#jBox-overlay').remove();
            }
        });
    });
}

/**
 * Function to assign random material colors to cards
 */
function randomizer() {
    var array=["#1abc9c","#27ae60","#2980b9","#9b59b6","#34495e","#f1c40f","#e67e22","#f74c3c","#7f8c8d","#131418","#e66e60","#2979FF","#5D4037","#ef9a9a","#ff1744","#FFC400"];
    $("div[data-class='card']").each(function randomizeColor(i) {
        // var x = Math.floor((Math.random() * 10) + 1);
            var color=array[i];
        console.log(color);
        $(this).css('background-color',color);
    });
}

/**
 * function to make menu fixed on top while scrolling
 */
$(window).bind('scroll', function () {
    if ($(window).scrollTop() > 500) {
        $('#mobile-header').addClass('fixed');
        $('#responsive-menu-button').click(function () {
            $.sidr("open","sidr");
        })
    } else {
        $('#mobile-header').removeClass('fixed');
    }
});

/**
 * Close the menubar after a selection is made
 */
$('#responsive-menu-button').click(function() {
    $.sidr('close', 'sidr');
});

/**
 * AJAX Call to get data from the IST API
 * @param t type of the call GET or PUT
 * @param d The datapath that is needed to be accessed
 * @param id The id to put spinner
 * @returns {*}
 */
function myXhr(t, d, id) {
    return $.ajax({
        type: t,
        url: 'proxy.php',
        dataType: 'json',
        data: d,
        cache: false,
        async: true,
        beforeSend: function () {
            //PLEASE - get your own spinner that 'fits' your site.
            //$(id).append('<img src="img/gears.gif" class="spin"/>');
        }
    }).always(function () {
        //kill spinner
        $(id).find('.spin').fadeOut(5000, function () {
            $(this).remove();
        });
    }).fail(function () {
        //handle failure
    });
}
