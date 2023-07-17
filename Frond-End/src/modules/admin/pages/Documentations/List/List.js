import React from 'react'
import { useQuery, useMutation, useQueryClient } from 'react-query'

import { getDocumentations, deleteDocumentation } from '../../../../../services/documentationService'

import Layout from '../../../layouts/Layout'
import Table from '../../../../../components/Table/Table'
import { useSelector } from 'react-redux'
import { toast } from 'react-toastify'

export default function List() {
	const queryClient = useQueryClient()

	const { theme } = useSelector(state => state.theme)
	
	const documentsQuery = useQuery('documents', getDocumentations)

	const deleteDocMutation = useMutation({
		mutationFn: deleteDocumentation,
		onSuccess: () => {
			queryClient.invalidateQueries()
			toast.success('Documentation deleted successfully', {theme})
		},
	})

	const handleDelete = id => {
		deleteDocMutation.mutate(id)
	}

	if(documentsQuery.isLoading) {
		<div>Loading...</div>
	}

	if(documentsQuery.error) {
		<div>{JSON.stringify(documentsQuery.error)}</div>
	}

	console.log(documentsQuery.data?.data?.result)

	const tableData = {
		title: 'Documentation List',
		createBtnUrl: '/admin/documentations/create',
		operations: {
			view: '/admin/documentations',
			delete: handleDelete,
		},
		headings: ['ID', 'Name', 'Description', 'Created Date'],
		rows: documentsQuery.data?.data?.result?.map(doc => {
			return {
				id: doc.id,
				name: doc.name,
				description: doc.description,
				created: doc.creationTime,
			}
		}) || []
	}

	return <Layout><Table data={tableData} /></Layout>
}
