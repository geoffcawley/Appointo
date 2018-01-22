import { Injectable } from '@angular/core';
import { Http, RequestOptions } from "@angular/http";
import { HttpModule } from '@angular/http/src/http_module';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class RoomsService {
	request: HttpClient;

	constructor(req: HttpClient) {
		this.request = req;
	 }

	getRooms() {
		// return this.request.get('http://localhost/appointoservice/api/rooms').toPromise();
		return this.request.get('http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/rooms').toPromise();
	}

	addRoom(roomNumber: number) {
		const body = {RoomNumber: roomNumber};
		let  myheaders = new Headers({ 'Content-Type': 'application/json' });
        // let options = new RequestOptions({ headers: myheaders, method: 'post' });
		this.request.post(
			// 'http://localhost/appointoservice/api/rooms',
			'http://ec2-18-216-243-172.us-east-2.compute.amazonaws.com/appointoservice/api/rooms',
			 body,
		).subscribe();
	}
}
