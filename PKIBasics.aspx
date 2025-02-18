<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PKIBasics.aspx.cs" Inherits="PKIBasics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Root CA - Myanmar Info-Tech Corporation</title>
    <link href="css/default.css" rel="stylesheet" type="text/css" media="screen" />
     <link rel="shortcut icon" href="~/images/final.png" type="image/x-icon" /> 
</head>

<body>
   <form id="Form1" name="form1" runat="server">

<div id="container-header">
	<div id="header">
		<ul id="nav">
			<li><a href="Default.aspx">Home</a></li>
			<li><a href="aboutus.aspx">About Us</a></li>
			<li ><a href="ActivitiesNews.aspx">Activities News</a></li>
			<li id="current-page"><a href="resources.aspx">Resources</a></li>			
			<li><a href="Download.aspx">Download</a></li>		
			<li ><a href="crlnew.aspx">Certificate Revocation List</a></li>	
			<li><a href="certificates.aspx">Certificate Repository</a></li>
			
			<li><a href="contactus.aspx">Contact Us</a></li>
			
		</ul>
		
	</div>
	<div id="header-img">
	<img  src="images/14root-ca-MICTD long.jpg" alt="Myanmar Info-Tech Root CA" />
	</div>
</div>
<div id="container-advert">
	<div id="advert">
		<h1>Myanmar National Root CA</h1>
		<p>Secured, Trusted and Proven PKI Solutions</p>
		</div>
</div>

<div id="container-content"> 
<div id="news">
	    <p>&nbsp;</p>
		<h2>Frequently Asked Questions</h2>
		<p>&nbsp;</p>
		
		<ol>
		<li><a class="tocxref" href="#h-12.1">How do I get a Digital Signature Certificate?</a></li> 
        <li><a class="tocxref" href="#h-12.2">What is the function of the Root certificate?</a></li> 
        <li><a class="tocxref" href="#h-12.3">Where do I get Root CA Certificate?</a></li> 
		<li><a class="tocxref" href="#h-12.4">Is Root Certificate free?</a></li> 
        <li><a class="tocxref" href="#h-12.5">What are the different classes of Digital Certificates?</a></li> 
        <li><a class="tocxref" href="#h-12.6">Does a person require multiple Digital Signatures Certificates for different places or organizations?</a></li> 
        <li><a class="tocxref" href="#h-12.7">How does cross-border inter-operability work in relation to digital signatures?</a></li> 
        <li><a class="tocxref" href="#h-12.8">How often is auditing done? (Auditing Cycle Period)? Whether it is continuous process?</a></li> 
        <li><a class="tocxref" href="#h-12.9">What types of measures are being executed by Control Board for licensing a CA?</a></li> 
        <li><a class="tocxref" href="#h-12.10">Whether CPS differs for one CA to another CA?</a></li> 
        <li><a class="tocxref" href="#h-12.11">Can CA have sub CA?</a></li> 
        <li><a class="tocxref" href="#h-12.12">If a person is transferred from one post to another (say in govt. department), the digital signature will also change (yes/no)? Please explain?</a></li> 
        <li><a class="tocxref" href="#h-12.13">In what format the public key should be given to CA for certification?</a></li> 
        <li><a class="tocxref" href="#h-12.14">In paper world, date and the place where the paper has been signed is recorded and court proceedings are followed on that basis. What mechanism is being followed for dispute settlements in the case of digital signatures?</a></li> 
        <li><a class="tocxref" href="#h-12.15">What is the extent of liability of a CA in case of anti-national activities performed by a subscriber using digital signature and secure encrypted communication?</a></li> 
        <li><a class="tocxref" href="#h-12.16">One can sign a paper without the knowledge of a signer. Is it possible in digital signature also?</a></li> 
        <li><a class="tocxref" href="#h-12.17">Is there a "Specimen Digital Signature" like paper signature?</a></li> 
        <li><a class="tocxref" href="#h-12.18">Can digital signature be employed in wireless network?</a></li> 
        <li><a class="tocxref" href="#h-12.19">What is a Registration Authority (RA)?</a></li> 
        <li><a class="tocxref" href="#h-12.20">What is the difference between RA(Registration Authority) and CA(Certifying Authority)?</a></li> 
        <li><a class="tocxref" href="#h-12.21">What is Subscriber/ End User?</a></li> 
	    <li><a class="tocxref" href="#h-12.22">If somebody uses others computer, instead of his own computer, then is there any possibility of threat to the security of the owners/users digital signature?</a></li> 
	    <li><a class="tocxref" href="#h-12.23">Does Root CA enforce Disaster Recovery Centre for CAs?</a></li> 
	    <li><a class="tocxref" href="#h-12.24">If CA is out of business then if the subscriber is told to move to another CA then the subscriber has to get a new digital certificate. What happens to his/her earlier transactions? Does this not create a legal and financial problem?</a></li> 
	    <li><a class="tocxref" href="#h-12.25">What is a Digital Signature?</a></li> 
	    <li><a class="tocxref" href="#h-12.26">What is a Digital Certificate (DC)?</a></li> 
	    <li><a class="tocxref" href="#h-12.27">Why do I need a digital certificate?</a></li> 
	    <li><a class="tocxref" href="#h-12.28">Where can I use digital certificates?</a></li> 
	    <li><a class="tocxref" href="#h-12.29">How does a Digital Signature work?</a></li> 
	    <li><a class="tocxref" href="#h-12.30">Are Digital Signatures legally valid in Myanmar?</a></li> 
	    <li><a class="tocxref" href="#h-12.31">What is the difference between a Digital Signature and a Digital Certificate?</a></li> 
	    <li><a class="tocxref" href="#h-12.32">What are personal certificates (individual certificates)?</a></li> 
	    <li><a class="tocxref" href="#h-12.33">What is the difference between signing and encrypting an e-mail?</a></li> 
	    <li><a class="tocxref" href="#h-12.34">Can I send a secure e-mail to someone who does not have a Digital Certificate?</a></li> 
	    <li><a class="tocxref" href="#h-12.35">How do I know if the e-mail I have received is digitally signed or encrypted?</a></li> 
	    <li><a class="tocxref" href="#h-12.36">Can I use one digital certificate for multiple e-mail addresses?</a></li> 
	    <li><a class="tocxref" href="#h-12.37">Can digital signatures be used in wireless networks?</a></li> 
	    <li><a class="tocxref" href="#h-12.38">I have purchased a Digital Certificate as an individual. Can I use it for my website?</a></li> 
	    <li><a class="tocxref" href="#h-12.39">Am I allowed to use one web server certificate (SSL) for more than one website?</a></li> 
	    <li><a class="tocxref" href="#h-12.40">Is the information contained in my Digital Certificate automatically sent to the websites I visit?</a></li> 
	    <li><a class="tocxref" href="#h-12.41">What is a Root Certifying Authority (Root CA)?</a></li> 
	    <li><a class="tocxref" href="#h-12.42">What is Certification Authority(CA)?</a></li> 
	    <li><a class="tocxref" href="#h-12.43">Who are CAs in Myanmar?</a></li> 
	    <li><a class="tocxref" href="#h-12.44">What is a CRL?</a></li>
	    <li><a class="tocxref" href="#h-12.45">What is a CP?</a></li>
	    <li><a class="tocxref" href="#h-12.46">What is CPS?</a></li>
	    <li><a class="tocxref" href="#h-12.47">What is ARL?</a></li>
	     <li><a class="tocxref" href="#h-12.48">Where can I download the subscribers certificates?</a></li>
	    <li><a class="tocxref" href="#h-12.49">What is Subscriber Agreement?</a></li>  
	    <li><a class="tocxref" href="#h-12.50">How do I use Digital Certificate?</a></li>  
	        
	    </ol>
		
		<p>&nbsp;</p>
		<h4><a name="h-12.1">1.&nbsp;</a><a name="links">How do I get a Digital Signature Certificate?</a></h4>
		<p>The National Root CA issues certificate only to Certifying Authorities. CAs issue Digital Certificate to subscribers. You can approach any one of the following CAs for getting Digital Certificate. The address and website addresses are given below.</p>
		<p>1. Yatanarpon CA  &nbsp;&nbsp;&nbsp;     <a href="https://www.yatanarponca.com.mm">www.yatanarponca.com.mm</a></p>
		<p>2. MOSS CA       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       <a href="http://www.mossca.com.mm">www.mossca.com.mm</a></p>
				
		<h4><a name="h-12.2">2.&nbsp;</a><a name="links">What is the function of the Root certificate?</a></h4>
        <p>The Root CA certificate is used to sign the public keys of the CAs in Myanmar. It is the highest level of certificate in Myanmar. The Root CA certificate is a self-signed certificate.</p>
                
        <h4><a name="h-12.3">3.&nbsp;</a><a name="links">Where do I get Root CA Certificate?</a></h4>
        <p>Root CA’s certificate can be downloaded from Root CA web site: <a href="http://www.rootca.org.mm/Download.aspx">www.rootca.org.mm/Download.aspx.</a></p>
                
        <h4><a name="h-12.4">4.&nbsp;</a><a name="links">Is Root Certificate free?</a></h4>
        <p>Yes, it is free and you can downloaded from Root CA website <a href="http://www.rootca.org.mm/Download.aspx">www.rootca.org.mm/Download.aspx.</a></p>
        
         <h4><a name="h-12.5">5.&nbsp;</a><a name="links">What are the different classes of Digital Certificates?</a></h4> 
         <p>There are four classes of digital certificate as the following:-</p>
         <p>Class 0 Certificate: This certificate shall be issued only for demonstration/ test purposes.</p>
         <p>Class 1 Certificate: Class 1 certificates shall be issued to individuals/private subscribers. These certificates will confirm that user’s name (or alias) and E-mail address from an unambiguous subject within the Certifying Authorities database.</p>
         <p>Class 2 Certificate: These certificates will be issued for both business personnel and private individuals use. These certificates will confirm that the information in the application provided by the subscriber does not conflict with the information in well-recognized consumer databases.</p>
         <p>Class 3 Certificate: This certificate will be issued to individuals as well as organizations. As these are high assurance certificates, primarily intended for e-commerce applications, they shall be issued to individuals only on their personal (physical) appearance before the Certifying Authorities.</p>
         
        <h4><a name="h-12.6">6.&nbsp;</a><a name="links">Does a person require multiple Digital Signatures Certificates for different places or organizations?</a></h4>   
        <p>It is not mandatory. However, certificates could be issued for different purposes to the same individual. e.g. by the bank where the individual has an account, by the government to the individual as a citizen etc.</p>   
         
         <h4><a name="h-12.7">7.&nbsp;</a><a name="links">How does cross-border inter-operability work in relation to digital signatures?</a></h4>  
         <p>Clearly, all certificates, not to mention technology applications, cannot and would not be issued by a single CA. Multiple CA's do and must exist. Inter operability between CAs- national and cross-border - has been addressed as Cross Certification. The arrangement for cross certification by the licensed CA with a foreign CA along with the application shall be submitted to Root CA, Myanmar. The licensed CA shall not commence cross certification operations unless it has obtained the written or digital signature approval from Root CA, Myanmar.</p>
         
         <h4><a name="h-12.8">8.&nbsp;</a><a name="links">How often is auditing done? (Auditing Cycle Period)? Whether it is continuous process?</a></h4>     
        <p>Yes, auditing is a continuous process. A team from the Electronic Transactions Control Board and Root CA audits the CAs once a year.</p>
		
		<h4><a name="h-12.9">9.&nbsp;</a><a name="links">What types of measures are being executed by Control Board for licensing a CA?</a></h4>    
		<p>Detailed information, financial, technical and procedural is obtained from the CA as part of the application for license. These are examined and audited by the Electronic Transactions Control Board (Control Board). After the approval of the Electronic Transactions Central Body, the Control Board may issue the licence to operate as CA.</p>       		
		
		<h4><a name="h-12.10">10.&nbsp;</a><a name="links">Whether CPS differs for one CA to another CA?</a></h4> 
		<p>Yes.</p>
		
		<h4><a name="h-12.11">11.&nbsp;</a><a name="links">Can CA have sub CA?</a></h4> 
		<p>No. All CAs must be granted license by Root CA, Myanmar.</p>
		
		<h4><a name="h-12.12">12.&nbsp;</a><a name="links">If a person is transferred from one post to another (say in govt. department), the digital signature will also change (yes/no)? Please explain?</a></h4> 
		<p> Yes. If the content in the digital certificate need to be change, then a new certificate must be issued for that. Eg. On moving from one department to another, if the procedures in place so demand, then the existing certificate will be revoked and a new one issued. In any case, the digital signature generated is different each time, even if the same key has been used.</p>
		
		<h4><a name="h-12.13">13.&nbsp;</a><a name="links">In what format the public key should be given to CA for certification?</a></h4> 
		<p>In PKCS #10 format.</p>
		
		<h4><a name="h-12.14">14.&nbsp;</a><a name="links">In paper world, date and the place where the paper has been signed is recorded and court proceedings are followed on that basis. What mechanism is being followed for dispute settlements in the case of digital signatures?</a></h4>
		<p>Under the Electronic Transactions Law, 2004 Digital Signatures are at par with hand written signatures. The Electronic Transactions Central Body and the Electronic Transactions Control Board will settle the disputes arising from the use of digital certificates.</p>
		
		<h4><a name="h-12.15">15.&nbsp;</a><a name="links">What is the extent of liability of a CA in case of anti-national activities performed by a subscriber using digital signature and secure encrypted communication?</a></h4>
		<p>CA has no liability, since CA is only facilitating end-to-end secure communication using digital signature.</p>
		
		<h4><a name="h-12.16">16.&nbsp;</a><a name="links">One can sign a paper without the knowledge of a signer. Is it possible in digital signature also?</a></h4>
		<p>It depends upon the how the subscriber has kept his private keys. If private key is not stored securely, then it can be misused without the knowledge of the owner of the private key.</p>
		
		<h4><a name="h-12.17">17.&nbsp;</a><a name="links">Is there a "Specimen Digital Signature" like paper signature?</a></h4>
		<p>No. The Digital signature changes with content of the message.</p>
		
		<h4><a name="h-12.18">18.&nbsp;</a><a name="links">Can digital signature be employed in wireless network?</a></h4>
		<p>Yes.</p>
		
		<h4><a name="h-12.19">19.&nbsp;</a><a name="links">What is a Registration Authority (RA)?</a></h4>
		<p>A RA (Registration Authority) is an agent of the Certifying Authority who collects the application forms and related documents for Digital Certificates, verifies the information submitted and approves or rejects the application.</p>
		
		<h4><a name="h-12.20">20.&nbsp;</a><a name="links">What is the difference between RA(Registration Authority) and CA(Certifying Authority)?</a></h4>
		<p>Registration Authority means a person or an organization that is responsible for registration, identification and authentication of Certificate Applicants. (It means RA provides identification and authentication on behalf of CA.) CA issues digital certificate to subscribers only when the subscribers pass the identification and authentication by RA.</p>
		
		<h4><a name="h-12.21">21.&nbsp;</a><a name="links">What is Subscriber/ End User?</a></h4>
		<p>Subscriber (End User) means a person or an organization who is by any technologies identified as an authentic signer of an electronic signature. A subscriber will always have a digital signature certificate issued to him by a LCA. A subscriber is the entity named as the end-user subscriber of a certificate.</p>
		
		<h4><a name="h-12.22">22.&nbsp;</a><a name="links">If somebody uses others computer, instead of his own computer, then is there any possibility of threat to the security of the owners/users digital signature?</a></h4>
		<p>No, there is no threat to the security of the owner / users digital signature, if the private key lies on the e-token (smartcard /crypto token) and does not leave the e-token.</p>
		
		<h4><a name="h-12.23">23.&nbsp;</a><a name="links">Does Root CA enforce Disaster Recovery Centre for CAs?</a></h4>
		<p>Yes, it is a mandatory requirement for all CAs.</p>
		
		<h4><a name="h-12.24">24.&nbsp;</a><a name="links">If CA is out of business then if the subscriber is told to move to another CA then the subscriber has to get a new digital certificate. What happens to his/her earlier transactions? Does this not create a legal and financial problem?</a></h4>
		<p>Prior to cessation of operations the CA has to follow procedures as laid down by the Control Board. Such problems should not therefore exist.</p>
		
		<h4><a name="h-12.25">25.&nbsp;</a><a name="links">What is a Digital Signature?</a></h4>
		<p>A digital signature mimics in the virtual environment the function of a hand-written signature in printed documents. Information related to a unique user is encrypted in a private key that is appended to any message sent by this user. It authenticates the identity of the user and guarantees the integrity of the message.</p>
		
		<h4><a name="h-12.26">26.&nbsp;</a><a name="links">What is a Digital Certificate (DC)?</a></h4>
		<p>A digital certificate is an electronic equivalent of an identification card such as a passport or driving license. It unequivocally establishes the identity of the user when exchanging information over the internet.</p>
		
		<h4><a name="h-12.27">27.&nbsp;</a><a name="links">Why do I need a digital certificate?</a></h4>
		<p>A Digital Certificate authenticates your identity electronically. It also provides you with a high level of security for your online transactions by ensuring absolute privacy of the information exchanged using a digital certificate. You can use certificates to encrypt information such that only the intended recipient can read it. You can digitally sign information to assure the recipient that it has not been changed in transit, and also verify your identity as the sender of the message.</p>
		
		<h4><a name="h-12.28">28.&nbsp;</a><a name="links">Where can I use digital certificates?</a></h4>
		<p>You can use Digital Certificates for the following:</p>
		<p>•&nbsp;	For secure email and web-based transactions, or to identify other participants of web-based transactions.</p>
        <p>•&nbsp;	To prove ownership of a domain name and establish SSL / TLS encrypted secured sessions between your website and the user for web based transactions.</p>
        <p>•&nbsp;	As a developer, for proving authorship of a code and retaining integrity of the distributed software programs.</p>
        <p>•&nbsp;	For signing web forms, e-tendering documents, filing income tax returns, to access membership-based websites automatically without entering a user name and password etc.</p>
        
        <h4><a name="h-12.29">29.&nbsp;</a><a name="links">How does a Digital Signature work?</a></h4>
        <p>A digital certificate explicitly associates the identity of an individual/device with a pair of electronic keys - public and private keys - and this association is endorsed by the CA. The certificate contains information about a user's identity (for example, their name, email address, the date the certificate was issued and the name of the Certifying Authority that issued it.).</p>
        <p>These keys complement each other in that one does not function in the absence of the other. They are used by browsers and servers to encrypt and decrypt information regarding the identity of the certificate user during information exchange processes. The private key is stored on the user's computer hard disk or on an external device such as a smart card. The user retains control of the private key; it can only be used with the issued password.</p>
		<p>The public key is disseminated with the encrypted information. The authentication process fails if either one of these keys in not available or do not match. This means that the encrypted data cannot be decrypted and therefore, is inaccessible to unauthorized parties.</p>
		
		<h4><a name="h-12.30">30.&nbsp;</a><a name="links">Are Digital Signatures legally valid in Myanmar?</a></h4>
		<p>Yes, the enactment of the Electronic Transactions Law  2004  in Myanmar, Digital Signatures are legally valid in Myanmar.</p>
		
		<h4><a name="h-12.31">31.&nbsp;</a><a name="links">What is the difference between a Digital Signature and a Digital Certificate?</a></h4>
		<p>A digital signature is an electronic method of signing an electronic document whereas a Digital Certificate is a computer based record that</p>
		<p>•&nbsp;&nbsp;	Identifies the Certifying Authority issuing it</p>
        <p>•&nbsp;&nbsp;	Has the name or the identity of its subscriber</p>
        <p>•&nbsp;&nbsp;	Contains the subscriber's public key</p>
        <p>•&nbsp;&nbsp;	Is digitally signed by the Certifying Authority issuing it.</p>

		<h4><a name="h-12.32">32.&nbsp;</a><a name="links">What are personal certificates (individual certificates)?</a></h4>
		<p>Personal certificates serve to identify a person. They can be used to secure e-mail correspondence or provide enhanced access control to sensitive or valuable information.</p>
		
		<h4><a name="h-12.33">33.&nbsp;</a><a name="links">What is the difference between signing and encrypting an e-mail?</a></h4>
		<p>Signing an e-mail message means that you attach your Digital Certificate to it so that the recipient knows it came from you and was not tampered with en-route to their inbox. Signing authenticates a message, but it does not provide protection against third party monitoring.</p>
		<p>Encrypting a message means scrambling it in such a way that only the designated recipients can unscramble it. This safeguards messages against monitoring or interception. In order to send a signed message, you must have a Digital Certificate. Since message encryption is done using specific keys available in the certificate, you cannot encrypt a message unless you possess the recipient's Digital Certificate.</p>
		
		<h4><a name="h-12.34">34.&nbsp;</a><a name="links">Can I send a secure e-mail to someone who does not have a Digital Certificate?</a></h4>
		<p>You can digitally sign any e-mail as long as the recipient has an e-mail application, which supports S/MIME. However, you cannot encrypt a message, unless you have the recipient's Digital Certificate.</p>
		
		<h4><a name="h-12.35">35.&nbsp;</a><a name="links">How do I know if the e-mail I have received is digitally signed or encrypted?</a></h4>
		<p>Microsoft Internet Explorer Users: Signed messages will be shown in the inbox (or any other folder) with a red ribbon on the envelope icon. Encrypted messages will show a padlock on the envelope icon.</p>
		<p>Netscape Communicator Users: Any signed e-mail you receive will have a prominent icon in the upper-right corner of the message saying "signed" or "encrypted" or both. If you want more information about the security of a message, click on the Security button (padlock icon) above the message.</p>
		
		<h4><a name="h-12.36">36.&nbsp;</a><a name="links">Can I use one digital certificate for multiple e-mail addresses?</a></h4>
		<p>No, you cannot. A digital certificate e-mail address combination is unique.</p>
		
		<h4><a name="h-12.37">37.&nbsp;</a><a name="links">Can digital signatures be used in wireless networks?</a></h4>
		<p>Yes, digital signatures can be employed in wireless networks.</p>
		
		<h4><a name="h-12.38">38.&nbsp;</a><a name="links">I have purchased a Digital Certificate as an individual. Can I use it for my website?</a></h4>
		<p>No, you cannot use a Digital Certificate that has been purchased by you as an individual for your website. A Digital Certificate meant for use by an individual is applicable to sending and receiving secure email and executing personal web-based transactions through web browsers. If you require a Digital Certificate for your website, you need to purchase one that is specific to the functionality of the web-based transactions handled on your website.</p>
		
		<h4><a name="h-12.39">39.&nbsp;</a><a name="links">Am I allowed to use one web server certificate (SSL) for more than one website?</a></h4>
		<p>No. You will not be able to use one certificate on different websites because the certificate is explicitly associated with the exact host and domain name.</p>
		
		<h4><a name="h-12.40">40.&nbsp;</a><a name="links">Is the information contained in my Digital Certificate automatically sent to the websites I visit?</a></h4>
		<p>No, you control the presentation of your Digital Certificates to websites through the settings in your web browser.</p>
		<p>To define whether or not you would like your Digital Certificate to be sent automatically to the websites you access, the set up procedure is as follows:</p>
		<p>Microsoft Internet Explorer Users: Internet Explorer always asks you whether to send Digital Certificate information to any website requesting it, and allows you to choose which Digital Certificate to use (if you have more than one installed).</p>
		
		<h4><a name="h-12.41">41.&nbsp;</a><a name="links">What is a Root Certifying Authority (Root CA)?</a></h4>
		<p>Root certification Authority is an entity officially designated under the Electronic Transactions Law, 2004 and by the Electronic Transactions Central Body to provide technical support to the Electronic Transactions Control Board (Control Board) with regard to electronic transactions inside the Union of Myanmar. Root Certification Authority (Root CA) is  responsible for issuing, managing, revoking, renewing certificates to CA. Root CA is the most trusted CA. Myanmar Info-Tech Corp. Ltd is the National Root CA of Myanmar assigned by the Electronic Transactions Control Board.</p>
		
		<h4><a name="h-12.42">42.&nbsp;</a><a name="links">What is Certification Authority(CA)?</a></h4>
		<p>Certification Authorities are organizations who  has been granted licence (or) permission by the Central Body and can perform as a CA in Myanmar. CAs issue digital certificates to Subscribers. CA's may be a person or an organization.</p>
		<p>Licenced local CAs inside the country provide service to End User Subscribers (End User) and Relying Parties in accordance with stipulations of CPS.</p>
		
		<h4><a name="h-12.43">43.&nbsp;</a><a name="links">Who are CAs in Myanmar?</a></h4>
		<p>There are two CA in Myanmar.  Yatanarpon CA(<a href="https://www.yatanarponca.com.mm">www.yatanarponca.com.mm</a>) and  MOSS CA (<a href="http://www.mossca.com.mm">www.mossca.com.mm</a>).</p>
		
		<h4><a name="h-12.44">44.&nbsp;</a><a name="links">What is a CRL?</a></h4>
		<p>The Certificate Revocation List (CRL) is a list of certificates that have been revoked by the CA, and are therefore no longer valid.</p>
		
		<h4><a name="h-12.45">45.&nbsp;</a><a name="links">What is a CP?</a></h4>
		<p>Certifying Authorities issue Digital Certificates that are appropriate to specific purposes or applications. A Certificate Policy (CP) describes the different classes of certificates issued by the CA, the procedures governing their issuance and revocation and terms of usage of such certificates, besides information regarding the rules governing the different uses of these certificates. General CP framework is given by the Control Board.</p>
		
		<h4><a name="h-12.46">46.&nbsp;</a><a name="links">What is CPS?</a></h4>
		<p>Certification Practice Statement (CPS) means a statement of the practices that a Certificate Authority employs in issuing certificates.</p>
		
		<h4><a name="h-12.47">47.&nbsp;</a><a name="links">What is ARL?</a></h4>
		<p>Authority Revocation List (ARL) means a periodically issued List (time stamping list) issued and digitally signed by the Root CA of identified Certificates that have been revoked, and published in the National Repository for publicly accessible.</p>
		
		<h4><a name="h-12.48">48.&nbsp;</a><a name="links">Where can I download the subscribers certificates?</a></h4>
		<p>You can download subscriber certificates issued by CAs from the National Repository of Root CA web site: <a href="http://www.rootca.org.mm/certificates.aspx">www.rootca.org.mm/certificates.aspx.</a></p>
		
		<h4><a name="h-12.49">49.&nbsp;</a><a name="links">What is Subscriber Agreement?</a></h4>
		<p>A Subscriber Agreement is an agreement between Subscriber and a CA stating that the subscriber will use the Digital Certificate for the assigned use or objective and that the subscriber is solely responsible for the protection of the private key and ensuring functionality of the unique key pair. The subscriber also agrees through the Subscriber Agreement that all the information provided to the CA at the time of registration is accurate. In the event of any change in information, the subscriber is obliged to immediately inform CA.</p>
			    
	    <h4><a name="h-12.50">50.&nbsp;</a><a name="links">How do I use Digital Certificate?</a></h4>
		<p>When you receive digitally signed messages, you can verify the signer's Digital signature to determine that no forgery or false representation has occurred.</p>
		<p>When you send messages, you can sign the messages and enclose your Digital certificate to assure the recipient of the message that the message was actually sent by you. Multiple Digital Certificates can be enclosed with a message, forming a hierarchical chain, wherein one Digital Certificate testifies to the authenticity of the previous Digital Certificate. At the end of a PKI hierarchy is a top-level Certification Authority called Root CA, which is trusted without a Digital Certificate from any other Certification Authority. The public key of the top-level Certification Authority must be independently known, for example by being widely published. The more familiar you are to the recipient of the message, the less need there is to enclose Digital Certificate.</p>
		<p>You can also use a Digital Certificate to identify yourself to secure servers such as membership-based web servers. This is called authentication. Generally, once you've obtained a Digital Certificate, you can set up your security-enhanced web or E-mail application to use the Digital Certificate automatically.</p>
		
		<br />
		<p> <a href="resources.aspx">Back</a></p>
	

</div>	
	
</div>

<div class="clear">&nbsp;</div>

<div id="footer" >
	Copyright © 2012,Myanmar ICT Development Corporation Ltd. All Rights Reserved.	
	 
	</div>
	
</form>
</body>
</html>