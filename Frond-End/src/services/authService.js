import { api } from './api'

export const me = () => {
  return api.get('/services/app/Session/GetCurrentLoginInformations', {
		headers: { Authorization: localStorage.getItem('token') },
	})
}