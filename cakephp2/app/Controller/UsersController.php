<?php
App::uses('AppController', 'Controller');
App::uses('User','Model');
App::build(array('Vendor' => array(APP . 'Vendor' . DS . 'league' . DS. 'oauth2-google' . DS . 'src'. DS . 'Provider' . DS . 'Google')));
debug(array('Vendor' => array(APP . 'Vendor' . DS . 'league' . DS. 'oauth2-google' . DS . 'src'. DS . 'Provider'. DS . 'Google')));
App::uses('Google', 'Vendor');
// use League\OAuth2\Client\Provider\Google;oauth2-google\src\Provider
class UsersController extends AppController {
	public $authUrl;
	// public $newRule = new PackageName\SubFolder\SubSubFolder\Rule();
	public function index() {
		$this->createGoogleAPI();
		$emailSession = $this->Session->read('emailSession');
		$passSession = $this->Session->read('passSession');
		$this->set(compact('emailSession','passSession','authUrl'));
	}
	public function addUser() {
		$this->layout = false;
		$this->render('add_user');
	}
	public function add() {
		$this->layout = false;
		$response = [];
		if($this->request->is('post')) {
			$data = $this->request->data;
			$validateError = $this->User->validateAddUser($data);
			if(count($validateError) == 0) {
				$result = $this->User->addUser($data);
				if($result) {
					$this->Session->write('User',$data);
					$response['type'] = 'success';
					$response['msg'] = "Thêm Thành Công";
				} else {
					$response['type'] = 'fail';
					$response['msg'] = 'Thêm thất bại';
				}
			} else {
				$response['type'] = 'fail';
				$response['msg'] = $validateError;
			}
		}
		$this->render(false);
		$this->response->body(json_encode($response));
		$this->response->type('application/json');
		return $this->response;
	}
	public function loginFB() {
		$userData = array();
		$this->layout = 'ajax';
		$this->autoRender = false;
		$dataUserFB = json_decode($_POST['userData']);
		if(!empty($dataUserFB)){
			$userData['fb_id'] = $dataUserFB->id;
			$userData['name'] = $dataUserFB->first_name." ".$dataUserFB->last_name;
			$userData['email'] = $dataUserFB->email;
			$userData['avatar_face'] = "https://graph.facebook.com/".$userData['fb_id']."/picture?type=large";
			
			$now = date('Y:m:d H:i:s');
			$userData['date_created'] = $now;
			$userData['date_updated'] = $now;
			$userData['group_id'] = 3;
			$userDataInsert['User'] = $userData;
			$data = $this->User->checkExistUser($userData);
			if (!empty($data)) {
				debug(1);
				$this->Session->write('User',$data);
				return json_encode($data);
			} else {
				if($this->User->save($userDataInsert)){
					$this->Session->write('User',$userDataInsert);
					return json_encode($userData);
				} else {
					return false;
				}
			}
		}
	}
	public function loginSuccess() {
		$this->render("index_unused");
	} 
	public function logout(){
		$this->Session->delete('User');
		$this->redirect(array('action' => 'index'));
	}
	public function loginNormal() {
		$this->layout = false;
		$response = [];
		if($this->request->is('post')) {
			$data = $this->request->data;
			if(isset($data['remember-me']) && $data['remember-me'] == 1) {
				$this->Session->write('emailSession', $data['email']);
				$this->Session->write('passSession', $data['password']);
			}
			$validateError = $this->User->validateUser($data);
			if (count($validateError) == 0) {
				$result = $this->User->loginNormal($data);
				if($result) {
					$this->Session->write('User',$data);
					$response['type'] = 'success';
				} else {
					$response['type'] = 'fail';
					$response['msg'] = 'Tài khoản không tồn tại hoặc mật khẩu sai';
				}
			} else {
				$response['type'] = 'fail';
				$response['msg'] = $validateError;
			}
		}
		$this->render(false);
		$this->response->body(json_encode($response));
		$this->response->type('application/json');
		return $this->response;
	}
	function createGoogleAPI() {
		$provider = new Google([
			'clientId'     => '658802540020-89g2be51rl538bgs5qndiqae93kohfs3.apps.googleusercontent.com',
			'clientSecret' => 'f2_TQrv8brLVi-1fQwdvHxPP',
			'redirectUri'  => 'http://localhost:8081/cakephp2/users/loginSuccess',
			// 'hostedDomain' => 'example.com', // optional; used to restrict access to users on your G Suite/Google Apps for Business accounts
		]);
		
		if (!empty($_GET['error'])) {
		
			// Got an error, probably user denied access
			exit('Got error: ' . htmlspecialchars($_GET['error'], ENT_QUOTES, 'UTF-8'));
		
		} elseif (empty($_GET['code'])) {
		
			// If we don't have an authorization code then get one
			$this->authUrl = $provider->getAuthorizationUrl();
			$_SESSION['oauth2state'] = $provider->getState();
			header('Location: ' . $authUrl);
			exit;
		
		} elseif (empty($_GET['state']) || ($_GET['state'] !== $_SESSION['oauth2state'])) {
		
			// State is invalid, possible CSRF attack in progress
			unset($_SESSION['oauth2state']);
			exit('Invalid state');
		
		} else {
		
			// Try to get an access token (using the authorization code grant)
			$token = $provider->getAccessToken('authorization_code', [
				'code' => $_GET['code']
			]);
		
			// Optional: Now you have a token you can look up a users profile data
			try {
		
				// We got an access token, let's now get the owner details
				$ownerDetails = $provider->getResourceOwner($token);
		
				// Use these details to create a new profile
				printf('Hello %s!', $ownerDetails->getFirstName());
		
			} catch (Exception $e) {
		
				// Failed to get user details
				exit('Something went wrong: ' . $e->getMessage());
		
			}
		
			// Use this to interact with an API on the users behalf
			echo $token->getToken();
		
			// Use this to get a new access token if the old one expires
			echo $token->getRefreshToken();
		
			// Unix timestamp at which the access token expires
			echo $token->getExpires();
		}
	}
}