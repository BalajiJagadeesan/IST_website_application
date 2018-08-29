/**
 * Created by Balaji Jagadeesan on 11/05/2016.
 */
Project 2-JQuery :

Overview:
	Created a near clone of our RIT IST dept website with following content with own styling
		-> About section
		-> Undergraduate Program and courses offered in UG program
		-> Graduate Program and courses offered in UG program
		-> Minors Offered @ RIT and courses details comprised in each Minors offered
		-> Employment statistics and relavant details
		-> Faculty and staff information
		-> Map data 
		-> Tables consisting of both CO-OP and Employment
	
	Main jQuery version used in project
		-> jquery-3.1.1.min.js (For newer Versions)
		-> jquery-1.12.4.min.js (For older versions)
		-> jquery-migrate-1.4.1.min.js and jquery-migrate-3.0.0.min.js for plugin backward compatability
		
	The following jQuery plugins were used 
		->Stellar - For parallax effect in the website (http://markdalgleish.com/projects/stellar.js/)
		->Sidr - For NavBar generation (https://www.berriart.com/sidr/)
		->outdatedbrowser - For cool UI redirect to custom browser.html page (http://outdatedbrowser.com/en)
		->dataTables - For generation of custom tables with search functionality and pagination (https://datatables.net/)
		->jBox- Modal plugin to give additional content in modal view (http://stephanwagner.me/jBox)
		->Diamonds JS- To align pic in diamond structure (http://mqchen.github.io/jquery.diamonds.js/)
		
	<Note: The above plugin are used with their respective .css file provided by their author>
	<Fonts and icons: Icons used in the project are imported with the help font-awesome (http://fontawesome.io/)>
	<Browser compatability: Tested on IE 10+ ,mozilla firefox and Google Chrome(Redirects if IE<10 due to google map data and jQuery compatability issue )> 

Functionality: 
	->Data fetch - All data used in the page is dynamically obtained from "http://ist.rit.edu/api/" and rendered to users on request.
	
	->Design scheme - The page follows material design scheme with card and material colors.Material colors are generated and applied dynamically using colors stored in array. 
	
	->Browser redirect : Redirects the user to a custom page (browser.html) if the browser is not compatabile using "outdatedbrowser plugin"
	
	->Menu bar - Custom menu is created using "sidr plugin" (slides in from left when menu button on top left corner is clicked)
	
	->Parallax - The parallax effect (relative scrolling) is implemented on the sections using "stellar plugin".
	
	->Additional Info : The additional info like info about a course or people is generated dynamically and rendered using "jBox plugin" (<Note: Since rendered dynamically it takes 2 clicks to actually generate the jBox (More info below under "problems" section)>)
	
	->Table content with interactive search and pagination - A table is generated using ajax call data, appended to a jBox and rendered using "dataTables plugin"
	
	->Diamond styling to people content - The data fetched from ajax call is neatly aligned using "diamond plugin" and created a toggle tab to toggle between faculty and staff.
	
	->Animation - Menu will slide from left,jBox will flip and popup content.
	
Problems:

JBox - During first time ,needed to be clicked 2 times with one sec gap to create the jBox Modal.The next time the jBox will be generated with single click.
		(Might be due to the fact  that the data is from ajax call)

Browser compatability - Page works properly with IE 10+,mozilla firefox and google chrome(created redirect for other browser versions)
