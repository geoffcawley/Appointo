import { Injectable } from '@angular/core';
import { Http } from "@angular/http";
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

}
