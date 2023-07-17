import { api } from './api'

export const getUsers = () => {
  return api.get('/services/app/User/GetAll', {
		headers: { Authorization: localStorage.getItem('token') },
	})
}

export const updateUser = data => {
	return api.put('/services/app/User/Update', data, {headers: { Authorization: localStorage.getItem('token') }})
}