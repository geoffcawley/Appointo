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
		return this.request.get('http://localhost/appointoservice/api/rooms').toPromise();
	}

	addRoom(roomNumber: number) {
		const body = {RoomNumber: roomNumber};
		let  myheaders = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: myheaders, method: 'post' });
		this.request.post(
			'http://localhost/appointoservice/api/rooms',
			 body,
			 new Headers({ 'Content-Type': 'application/json' })
		).subscribe();
	}
}
