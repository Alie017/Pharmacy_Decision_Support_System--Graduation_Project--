import React from 'react'
import { useQuery } from 'react-query'
import { getUsers } from '../../../../../services/userService'
import Layout from '../../../layouts/Layout'
import Table from '../../../../../components/Table/Table'

export default function UserList() {
	const usersQuery = useQuery('users', getUsers)

	if(usersQuery.isLoading) {
		<div>Loading...</div>
	}

	const tableData = {
		title: 'User List',
		operations: {},
		headings: ['ID', 'Name', 'Surname', 'Email'],
		rows: usersQuery.data?.data?.result.items.map(user => {
			return {
				id: user.id,
				name: user.name,
				surname: user.surname,
				email: user.emailAddress,
			}
		}) || [],
	}

  return (
		<Layout>
			<Table data={tableData} />
		</Layout>
	)
}
